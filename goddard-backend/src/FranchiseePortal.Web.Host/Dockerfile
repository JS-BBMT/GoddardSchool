#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

RUN apt-get update -y
RUN apt-get install -y libgdiplus libc6-dev
RUN cd /usr/lib
RUN ln -s libgdiplus.so gdiplus.dll

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["src/FranchiseePortal.Web.Host/FranchiseePortal.Web.Host.csproj", "src/FranchiseePortal.Web.Host/"]
COPY ["src/FranchiseePortal.Web.Core/FranchiseePortal.Web.Core.csproj", "src/FranchiseePortal.Web.Core/"]
COPY ["src/FranchiseePortal.Application/FranchiseePortal.Application.csproj", "src/FranchiseePortal.Application/"]
COPY ["src/FranchiseePortal.Application.Shared/FranchiseePortal.Application.Shared.csproj", "src/FranchiseePortal.Application.Shared/"]
COPY ["src/FranchiseePortal.Core.Shared/FranchiseePortal.Core.Shared.csproj", "src/FranchiseePortal.Core.Shared/"]
COPY ["src/FranchiseePortal.Core/FranchiseePortal.Core.csproj", "src/FranchiseePortal.Core/"]
COPY ["src/FranchiseePortal.EntityFrameworkCore/FranchiseePortal.EntityFrameworkCore.csproj", "src/FranchiseePortal.EntityFrameworkCore/"]
COPY ["src/FranchiseePortal.GraphQL/FranchiseePortal.GraphQL.csproj", "src/FranchiseePortal.GraphQL/"]
RUN dotnet restore "src/FranchiseePortal.Web.Host/FranchiseePortal.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/FranchiseePortal.Web.Host"
RUN dotnet build "FranchiseePortal.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FranchiseePortal.Web.Host.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "FranchiseePortal.Web.Host.dll"]
