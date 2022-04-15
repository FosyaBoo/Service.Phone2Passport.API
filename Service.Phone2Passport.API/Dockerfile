#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Service.Phone2Passport.API.csproj", "Service.Phone2Passport.API/"]
COPY ["Service.Phone2Passport.Business/Service.Phone2Passport.Business.csproj", "Service.Phone2Passport.Business/"]
COPY ["Service.Phone2Passport.DataAccess/Service.Phone2Passport.DataAccess.csproj", "Service.Phone2Passport.DataAccess/"]
RUN dotnet restore "Service.Phone2Passport.API/Service.Phone2Passport.API.csproj"
COPY . .
WORKDIR "/src/Service.Phone2Passport.API"
RUN dotnet build "Service.Phone2Passport.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Service.Phone2Passport.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Service.Phone2Passport.API.dll"]