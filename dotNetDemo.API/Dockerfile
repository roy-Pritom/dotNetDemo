# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

COPY dotNetDemo.API/dotNetDemo.API.csproj dotNetDemo.API/
RUN dotnet restore dotNetDemo.API/dotNetDemo.API.csproj

COPY dotNetDemo.API/ dotNetDemo.API/
RUN dotnet publish dotNetDemo.API/dotNetDemo.API.csproj -c Release -o /app/publish /p:UseAppHost=false

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final
WORKDIR /app
COPY --from=build /app/publish .

EXPOSE 8080
ENV ASPNETCORE_URLS=http://+:8080
USER app

ENTRYPOINT ["dotnet", "dotNetDemo.API.dll"]
