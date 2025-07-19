#!/bin/bash

docker exec -t caspnetti_aspnet_test bash -c "dotnet ef database update --project Caspnetti.API"
