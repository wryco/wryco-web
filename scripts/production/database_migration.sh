#!/bin/bash

docker exec -t wryco_aspnet_production bash -c "dotnet ef migrations add \"$@\" --project Wryco.DAL"
