#!/bin/bash

# Copy default .env if .env.local does not already exist for all services:
cp -n docker/production/adminer/.env docker/production/adminer/.env.local
cp -n docker/production/aspnet/.env docker/production/aspnet/.env.local
cp -n docker/production/mssql/.env docker/production/mssql/.env.local
cp -n docker/production/vue/.env docker/production/vue/.env.local

cp -n docker/production/nginx/wryco-ssl.conf docker/production/nginx/wryco-ssl.conf.local
cp -n docker/production/nginx/wryco.conf docker/production/nginx/wryco.conf.local
