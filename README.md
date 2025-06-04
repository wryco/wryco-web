# How this project was created?

I installed docker on my machine:

https://docs.docker.com/get-started/

I manually created the following files and directories:

```
docker
-backend
--Dockerfile
docker-compose.yml
```

Then I defined the backend dockerfile:

```
# Specifies an image to extend from: https://hub.docker.com/r/microsoft/dotnet-sdk
FROM mcr.microsoft.com/dotnet/sdk:9.0

# Update our apt deps in case we need to install anything later
RUN apt update
RUN apt upgrade -y

# A quick little dotnet utility script for setting up for serving traffic over https
RUN dotnet dev-certs https --trust

# https://learn.microsoft.com/en-us/ef/core/get-started/overview/install#get-the-net-core-cli-tools
# Installing dotnet globally
RUN dotnet tool install --global dotnet-ef

# Add tools to path:
ENV PATH="$PATH:/root/.dotnet/tools"

# This definition keeps the container open, but there's more to it than that.
# Here's some context https://chatgpt.com/share/683fdeab-e500-800d-a717-ca53813db331
# I personally prefer "sleep infinity" over "tail -f /dev/null" as it can return in some cases.
ENTRYPOINT sleep infinity
```

With the backend dockerfile defined, I define the docker-compose.yml that uses it:

```
# Quick start for some additional context https://docs.docker.com/compose/gettingstarted/
services:

  # The name of the service
  caspnetti_backend:

    # Defining the build context and dockerfile
    build:
      context: ./
      dockerfile: ./docker/backend/Dockerfile

    # Label applied to the created container
    container_name: caspnetti_backend

    # Label applied to the created image
    image: caspnetti_backend

    # Port definitions (host:container)
    ports:
      - 8080:8080

    # Volume for syncing code between the host and container
    volumes:
      - ./src:/caspnetti
```

I start the build process and create the container:

```
docker compose up -d
```

I exec into the container:

```
docker exec -it caspnetti bash
```

I create a new solution file:

```
dotnet new sln --name Caspnetti
```

Then I create a new project and add them to the solution for each logical unit. I'll be splitting functionality into api, entity, service, and test projects:

```
dotnet new webapi --use-controllers -o Caspnetti.API
dotnet sln add Caspnetti.API
dotnet new classlib -o Caspnetti.DAL
dotnet sln add Caspnetti.DAL
dotnet new classlib -o Caspnetti.Service
dotnet sln add Caspnetti.Service
dotnet new xunit -o Caspnetti.Test
dotnet sln add Caspnetti.Test
```

Now I manage project dependencies, making sure to avoid circular referneces:

```
dotnet add Caspnetti.API reference Caspnetti.Service
dotnet add Caspnetti.API reference Caspnetti.DAL
dotnet add Caspnetti.Service reference Caspnetti.DAL
dotnet add Caspnetti.Test reference Caspnetti.DAL
dotnet add Caspnetti.Test reference Caspnetti.Service
```

Lastly, we add our project dependencies:

```

dotnet add Caspnetti.API package Microsoft.EntityFrameworkCore.Design
dotnet add Caspnetti.DAL package Microsoft.EntityFrameworkCore.Design
dotnet add Caspnetti.DAL package Microsoft.EntityFrameworkCore.SqlServer
dotnet add Caspnetti.DAL package Microsoft.Extensions.Configuration
dotnet add Caspnetti.DAL package Microsoft.Extensions.Configuration.Json
```

Manually updated
- Caspnetti.API/Program.cs
- Caspnetti.API/Properties/launchSettings.json

Manually created
- Caspnetti.DAL/ApplicationDbContext.cs
- Caspnetti.DAL/Entity/User.cs

Creating the initial migration:

```
dotnet ef migrations add init --project Caspnetti.DAL --startup-project Caspnetti.API
```

Running the migration:

```
dotnet ef database update --project Caspnetti.DAL --startup-project Caspnetti.API
```

Start the project:

```
dotnet run --project Caspnetti.API
```
