#!/bin/bash

# Copy sample .env files
cp docker/adminer/.env docker/adminer/.env.local
cp docker/backend/.env docker/backend/.env.local
cp docker/frontend/.env docker/frontend/.env.local
cp docker/mssql/.env docker/mssql/.env.local

cp docker/nginx/caspnetti-ssl.conf docker/nginx/caspnetti-ssl.conf.local
cp docker/nginx/caspnetti.conf docker/nginx/caspnetti.conf.local
