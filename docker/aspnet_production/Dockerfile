FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /caspnetti
RUN apt update
RUN apt upgrade -y
COPY ./src/backend/ .
RUN dotnet publish -c Release -o /publish

FROM mcr.microsoft.com/dotnet/sdk:9.0 AS final
WORKDIR /caspnetti
RUN dotnet dev-certs https --trust
RUN dotnet tool install --global dotnet-ef
ENV PATH="$PATH:/root/.dotnet/tools"
COPY --from=build /publish .
ENTRYPOINT dotnet Caspnetti.API.dll
