#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WorkoutsAPI.csproj", "."]
RUN dotnet restore "./WorkoutsAPI.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "WorkoutsAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WorkoutsAPI.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
#Copy the wait-for-it.sh script to the container
COPY ./wait-for-it.sh wait-for-it.sh
#Make the wait-for-it.sh script executable
RUN chmod +x wait-for-it.sh

WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WorkoutsAPI.dll"]
