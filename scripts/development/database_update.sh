#!/bin/bash

docker exec -t wryco_aspnet_development bash -c "dotnet ef database update --project Wryco.API"
