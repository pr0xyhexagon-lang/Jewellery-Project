# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY LuxeLayersLK.Web/LuxeLayersLK.Web.csproj LuxeLayersLK.Web/
RUN dotnet restore LuxeLayersLK.Web/LuxeLayersLK.Web.csproj

COPY LuxeLayersLK.Web/ LuxeLayersLK.Web/
RUN dotnet publish LuxeLayersLK.Web/LuxeLayersLK.Web.csproj -c Release -o /app/publish --no-restore

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app
COPY --from=build /app/publish .

ENV ASPNETCORE_ENVIRONMENT=Production
EXPOSE 8080

# Render (and similar hosts) pass the port to listen on in $PORT; fall back to 8080 locally.
ENTRYPOINT ["sh", "-c", "ASPNETCORE_HTTP_PORTS=${PORT:-8080} exec dotnet LuxeLayersLK.Web.dll"]
