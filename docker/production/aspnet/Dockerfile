FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /wryco
RUN apt update
RUN apt upgrade -y
COPY ./src/backend/ .
RUN dotnet publish -c Release -o /publish

FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS final
WORKDIR /wryco
COPY --from=build /publish .
ENTRYPOINT dotnet Wryco.API.dll
