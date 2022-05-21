FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["sheeple.Core/sheeple.Core.csproj", "sheeple.Core/"]
RUN dotnet restore "sheeple.Core/sheeple.Core.csproj"
COPY . .
WORKDIR "/src/sheeple.Core"
RUN dotnet build "sheeple.Core.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "sheeple.Core.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "sheeple.Core.dll"]
