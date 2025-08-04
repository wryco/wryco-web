#!/bin/bash

docker exec -t wryco_aspnet_test bash -c "dotnet ef migrations add \"$@\" --project Wryco.DAL"
