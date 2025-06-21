FROM nginx:bookworm

RUN apt update
RUN apt upgrade -y

RUN mkdir -p /etc/nginx/ssl

# Copy ssl config to temp dir
COPY ./docker/nginx_development/caspnetti-ssl.conf.local /tmp/caspnetti-ssl.conf

# Generate the key and cert (valid for 1 year)
RUN openssl req -x509 -nodes -days 365 -newkey rsa:4096 -keyout /etc/nginx/ssl/caspnetti.key -out /etc/nginx/ssl/caspnetti.crt -config /tmp/caspnetti-ssl.conf

# Generate mobile cert
# RUN openssl pkcs12 -export -out mobile-cert.p12 -inkey /etc/nginx/ssl/caspnetti.key -in /etc/nginx/ssl/caspnetti.crt

COPY ./docker/nginx_development/caspnetti.conf.local /etc/nginx/conf.d/caspnetti.conf
