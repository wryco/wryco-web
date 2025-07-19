#!/bin/bash

docker exec -t caspnetti_aspnet_development bash -c "dotnet ef database update --project Caspnetti.API"
