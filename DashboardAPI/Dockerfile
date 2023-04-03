#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app

EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["DashboardAPI.csproj", "."]
RUN dotnet restore "./DashboardAPI.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "DashboardAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "DashboardAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final

## Add the wait script to the image
ADD https://github.com/ufoscout/docker-compose-wait/releases/download/2.9.0/wait /wait
RUN chmod +x /wait

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["/bin/sh", "-c", "/wait && dotnet DashboardAPI.dll"]