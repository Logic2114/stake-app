FROM mcr.microsoft.com/dotnet/core/sdk:3.1.101 AS build
WORKDIR /app
EXPOSE 5001
EXPOSE 5000

WORKDIR /app/StakeApp.Data
COPY StakeApp.Data/*.csproj .

COPY StakeApp.Data/ .

WORKDIR /app/StakeApp.Web
COPY StakeApp.Web/*.csproj .
RUN dotnet restore

COPY StakeApp.Web/ .

RUN dotnet publish -c Release -o out 



FROM mcr.microsoft.com/dotnet/core/sdk:3.1.101
WORKDIR /app
COPY --from=build /app/StakeApp.Web/out .
ENTRYPOINT ["dotnet", "StakeApp.Web.dll"]