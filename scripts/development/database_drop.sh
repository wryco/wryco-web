#!/bin/bash

docker exec -it wryco_aspnet_development bash -c "dotnet ef database drop --project Wryco.API"
