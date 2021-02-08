#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["host/EasyAbp.ReviewManagement.Web.Unified/EasyAbp.ReviewManagement.Web.Unified.csproj", "host/EasyAbp.ReviewManagement.Web.Unified/"]
COPY ["src/EasyAbp.ReviewManagement.Web/EasyAbp.ReviewManagement.Web.csproj", "src/EasyAbp.ReviewManagement.Web/"]
COPY ["src/EasyAbp.ReviewManagement.HttpApi/EasyAbp.ReviewManagement.HttpApi.csproj", "src/EasyAbp.ReviewManagement.HttpApi/"]
COPY ["src/EasyAbp.ReviewManagement.Application.Contracts/EasyAbp.ReviewManagement.Application.Contracts.csproj", "src/EasyAbp.ReviewManagement.Application.Contracts/"]
COPY ["src/EasyAbp.ReviewManagement.Domain.Shared/EasyAbp.ReviewManagement.Domain.Shared.csproj", "src/EasyAbp.ReviewManagement.Domain.Shared/"]
COPY ["src/EasyAbp.ReviewManagement.EntityFrameworkCore/EasyAbp.ReviewManagement.EntityFrameworkCore.csproj", "src/EasyAbp.ReviewManagement.EntityFrameworkCore/"]
COPY ["src/EasyAbp.ReviewManagement.Domain/EasyAbp.ReviewManagement.Domain.csproj", "src/EasyAbp.ReviewManagement.Domain/"]
COPY ["src/EasyAbp.ReviewManagement.Application/EasyAbp.ReviewManagement.Application.csproj", "src/EasyAbp.ReviewManagement.Application/"]
COPY ["host/EasyAbp.ReviewManagement.Host.Shared/EasyAbp.ReviewManagement.Host.Shared.csproj", "host/EasyAbp.ReviewManagement.Host.Shared/"]
COPY Directory.Build.props .
RUN dotnet restore "host/EasyAbp.ReviewManagement.Web.Unified/EasyAbp.ReviewManagement.Web.Unified.csproj"
COPY . .
WORKDIR "/src/host/EasyAbp.ReviewManagement.Web.Unified"
RUN dotnet build "EasyAbp.ReviewManagement.Web.Unified.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "EasyAbp.ReviewManagement.Web.Unified.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "EasyAbp.ReviewManagement.Web.Unified.dll"]
