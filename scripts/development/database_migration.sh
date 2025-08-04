#!/bin/bash

docker exec -t wryco_aspnet_development bash -c "dotnet ef migrations add \"$@\" --project Wryco.DAL"
