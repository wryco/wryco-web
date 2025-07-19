#!/bin/bash

docker exec -t caspnetti_aspnet_test bash -c "dotnet ef migrations add \"$@\" --project Caspnetti.DAL"
