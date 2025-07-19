#!/bin/bash

docker exec -t caspnetti_aspnet_development bash -c "dotnet ef migrations add \"$@\" --project Caspnetti.DAL"
