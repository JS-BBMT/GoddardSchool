#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/FranchiseePortal.Migrator/FranchiseePortal.Migrator.csproj", "src/FranchiseePortal.Migrator/"]
COPY ["src/FranchiseePortal.EntityFrameworkCore/FranchiseePortal.EntityFrameworkCore.csproj", "src/FranchiseePortal.EntityFrameworkCore/"]
COPY ["src/FranchiseePortal.Core/FranchiseePortal.Core.csproj", "src/FranchiseePortal.Core/"]
COPY ["src/FranchiseePortal.Core.Shared/FranchiseePortal.Core.Shared.csproj", "src/FranchiseePortal.Core.Shared/"]
RUN dotnet restore "src/FranchiseePortal.Migrator/FranchiseePortal.Migrator.csproj"
COPY . .
WORKDIR "/src/src/FranchiseePortal.Migrator"
RUN dotnet build "FranchiseePortal.Migrator.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FranchiseePortal.Migrator.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FranchiseePortal.Migrator.dll", "-s"]
