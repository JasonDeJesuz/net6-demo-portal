FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build


# WORKDIR "/Sheeple"
# COPY ["/Sheeple", "Sheeple/"]

# WORKDIR "/Sheeple.Core"
# COPY ["/Sheeple.Core", "Sheeple/"]

# WORKDIR "/Sheeple.Data"
# COPY ["/Sheeple.Data", "Sheeple/"]

# WORKDIR "/Sheeple.Shared"
# COPY ["/Sheeple.Shared", "Sheeple/"]

COPY [".", "Sheeple/"]

WORKDIR "."
COPY ["Sheeple.sln", "Sheeple/"]
RUN dotnet restore "/Sheeple/Sheeple.sln"
COPY . .
# WORKDIR "/Sheeple"
RUN dotnet build "/Sheeple/Sheeple.sln" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "/Sheeple/Sheeple.sln" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Sheeple.dll"]
