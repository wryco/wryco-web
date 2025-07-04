docker exec -t caspnetti_aspnet_production bash -c "dotnet ef migrations add \"$@\" --project Caspnetti.DAL"
