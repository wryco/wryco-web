#!/bin/bash

# Recreates all containers, images, networks, preserving derived images
docker compose down --rmi local
docker compose up -d
