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
