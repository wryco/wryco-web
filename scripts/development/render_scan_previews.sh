#!/bin/bash
docker exec -it wryco_nginx_development bash -c "cd /usr/share/nginx/html && mkdir -p preview && mogrify -path ./preview -resize '600x600>' ./scans/*.JPG"
