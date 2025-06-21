<h1 align="center">Caspnetti</h1>

![splash-image](./docs/assets/caspnetti-splash.jpg)

<blockquote align="center">"Mom's caspnetti"</blockquote>

### An opinionated and cooked c# asp.net core web application boilerplate featuring:

- 🚄 Stupid fast performance capable of handling [15,000+ requests/second](https://github.com/ramity/caspnetti/blob/master/docs/simple-benchmark.md)
- 🐋 Fully [dockerized](https://www.docker.com/) environment
- 📝 Code-first SQL and [migrations](https://learn.microsoft.com/en-us/ef/core/managing-schemas/migrations/managing?tabs=dotnet-core-cli) using [entity framework](https://learn.microsoft.com/en-us/ef/core/cli/dotnet)
- ⚖️ A controller, entity, service, and test abstraction pattern built for any scale
- 🔍 [Adminer](https://www.adminer.org/en/) for easy database viewing
- 👋 [Hey](https://github.com/rakyll/hey) for convient saturation testing
- 😎 [Swagger](https://learn.microsoft.com/en-us/aspnet/core/tutorials/web-api-help-pages-using-swagger?view=aspnetcore-8.0&viewFallbackFrom=aspnetcore-9.0) for living documentation and testing
- ⏺️ Custom docker container monitoring
- ✌️ [Vue.js](https://vuejs.org/) frontend
- 🅱️ [Bootstrap](https://getbootstrap.com/)
- 📺 Development and production ready services

## Quickstart:

Download [docker](https://docs.docker.com/) then run the following:

```
git clone git@github.com:ramity/caspnetti.git
cd caspnetti
./scripts/copy_env.sh
docker compose up -d
```

> It's that shrimple 🦐

## Frequently used commands:

Surgically destroy containers and images:

```
docker compose down --rmi local
```

Enter backend container:

```
docker exec -it caspnetti_backend bash
```

Build solution:

```
dotnet build
```

Start API

```
dotnet run --project Caspnetti.API
```

Create migration:

```
dotnet ef migrations add DESCRIPTION_HERE --project Caspnetti.DAL --startup-project Caspnetti.API
```

> Replacing `DESCRIPTION_HERE` with a description that captures what changes occured.

Run migrations:

```
dotnet ef database update --project Caspnetti.DAL --startup-project Caspnetti.API
```

Run tests:

```
dotnet test
```

## View API:

Navigate to https://localhost

## View database:

Navigate to http://localhost:8080
