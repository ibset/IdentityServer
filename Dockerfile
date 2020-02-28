FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["IdentityServer.Web/IdentityServer.Web.csproj", "IdentityServer.Web/"]
RUN dotnet restore "IdentityServer.Web/IdentityServer.Web.csproj"
COPY . .
WORKDIR "/src/IdentityServer.Web"
RUN dotnet build "IdentityServer.Web.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "IdentityServer.Web.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "IdentityServer.Web.dll"]