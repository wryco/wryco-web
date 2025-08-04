FROM nginx:bookworm

RUN apt update
RUN apt upgrade -y

RUN mkdir -p /etc/nginx/ssl

# Copy ssl config to temp dir
COPY ./docker/production/nginx/wryco-ssl.conf.local /tmp/wryco-ssl.conf

# Generate the key and cert (valid for 1 year)
RUN openssl req -x509 -nodes -days 365 -newkey rsa:4096 -keyout /etc/nginx/ssl/wryco.key -out /etc/nginx/ssl/wryco.crt -config /tmp/wryco-ssl.conf

COPY ./docker/production/nginx/wryco.conf.local /etc/nginx/conf.d/wryco.conf