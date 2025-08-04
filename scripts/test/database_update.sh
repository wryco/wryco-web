#!/bin/bash

docker exec -t wryco_aspnet_test bash -c "dotnet ef database update --project Wryco.API"
