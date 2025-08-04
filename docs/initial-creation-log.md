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
  wryco_backend:

    # Defining the build context and dockerfile
    build:
      context: ./
      dockerfile: ./docker/backend/Dockerfile

    # Label applied to the created container
    container_name: wryco_backend

    # Label applied to the created image
    image: wryco_backend

    # Port definitions (host:container)
    ports:
      - 8080:8080

    # Volume for syncing code between the host and container
    volumes:
      - ./src:/wryco
```

I start the build process and create the container:

```
docker compose up -d
```

I exec into the container:

```
docker exec -it wryco bash
```

I create a new solution file:

```
dotnet new sln --name Wryco
```

Then I create a new project and add them to the solution for each logical unit. I'll be splitting functionality into api, entity, service, and test projects:

```
dotnet new webapi --use-controllers -o Wryco.API
dotnet sln add Wryco.API
dotnet new classlib -o Wryco.DAL
dotnet sln add Wryco.DAL
dotnet new classlib -o Wryco.Service
dotnet sln add Wryco.Service
dotnet new xunit -o Wryco.Test
dotnet sln add Wryco.Test
```

Now I manage project dependencies, making sure to avoid circular referneces:

```
dotnet add Wryco.API reference Wryco.Service
dotnet add Wryco.API reference Wryco.DAL
dotnet add Wryco.Service reference Wryco.DAL
dotnet add Wryco.Test reference Wryco.DAL
dotnet add Wryco.Test reference Wryco.Service
```

Lastly, we add our project dependencies:

```

dotnet add Wryco.API package Microsoft.EntityFrameworkCore.Design
dotnet add Wryco.DAL package Microsoft.EntityFrameworkCore.Design
dotnet add Wryco.DAL package Microsoft.EntityFrameworkCore.SqlServer
dotnet add Wryco.DAL package Microsoft.Extensions.Configuration
dotnet add Wryco.DAL package Microsoft.Extensions.Configuration.Json
```

Manually updated
- Wryco.API/Program.cs
- Wryco.API/Properties/launchSettings.json
- Wryco.API/appsettings.json
- Wryco.API/appsettings.Development.json

Manually created
- Wryco.DAL/ApplicationDbContext.cs
- Wryco.DAL/Entity/User.cs

Creating the initial migration:

```
dotnet ef migrations add init --project Wryco.DAL --startup-project Wryco.API
```

Running the migration:

```
dotnet ef database update --project Wryco.DAL --startup-project Wryco.API
```

Start the project:

```
dotnet run --project Wryco.API
```
