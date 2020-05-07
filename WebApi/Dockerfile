FROM mcr.microsoft.com/dotnet/core/sdk:2.2 AS build-env
WORKDIR /app

COPY . ./
RUN dotnet publish WebApi -c Release -o out

FROM mcr.microsoft.com/dotnet/core/aspnet:2.2
WORKDIR /appdot
COPY --from=build-env /app/WebApi/out .

ENTRYPOINT ["dotnet", "WebApi.dll"]