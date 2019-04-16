FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-alpine AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-alpine AS build
WORKDIR /src
COPY ["NetCoreWorker/NetCoreWorker.csproj", "NetCoreWorker/"]
RUN dotnet restore "NetCoreWorker/NetCoreWorker.csproj"
COPY . .
WORKDIR "/src/NetCoreWorker"
RUN dotnet build "NetCoreWorker.csproj" -c Release -o /app
RUN dotnet publish "NetCoreWorker.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "NetCoreWorker.dll"]