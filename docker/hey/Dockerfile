FROM golang:1.24-bookworm

RUN apt update
RUN apt upgrade -y
RUN go install github.com/rakyll/hey@latest
ENV PATH="$PATH:/root/go/bin"

ENTRYPOINT sleep infinity
