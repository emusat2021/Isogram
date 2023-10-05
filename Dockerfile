FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

COPY Isogram.app/*.csproj ./Isogram.app/

WORKDIR /app/Isogram.app
RUN dotnet restore

WORKDIR /app
COPY Isogram.app Isogram.app

WORKDIR /app/Isogram.app
RUN dotnet publish -c Release -o out

FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/Isogram.app/out ./
ENV ASPNETCORE_ENVIRONMENT Development
EXPOSE 80
ENTRYPOINT ["dotnet", "Isogram.app.dll"]
