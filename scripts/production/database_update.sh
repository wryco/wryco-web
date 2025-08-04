#!/bin/bash

docker exec -t wryco_aspnet_production bash -c "dotnet ef database update --project Wryco.API"
