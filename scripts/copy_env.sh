#!/bin/bash

# Copy default .env if .env.local does not already exist for all services:
cp -n docker/adminer/.env docker/adminer/.env.local
cp -n docker/aspnet_development/.env docker/aspnet_development/.env.local
cp -n docker/aspnet_production/.env docker/aspnet_production/.env.local
cp -n docker/mssql/.env docker/mssql/.env.local
cp -n docker/nginx_development/caspnetti-ssl.conf docker/nginx_development/caspnetti-ssl.conf.local
cp -n docker/nginx_development/caspnetti.conf docker/nginx_development/caspnetti.conf.local
cp -n docker/nginx_production/caspnetti-ssl.conf docker/nginx_production/caspnetti-ssl.conf.local
cp -n docker/nginx_production/caspnetti.conf docker/nginx_production/caspnetti.conf.local
cp -n docker/vue_development/.env docker/vue_development/.env.local
cp -n docker/vue_production/.env docker/vue_production/.env.local
