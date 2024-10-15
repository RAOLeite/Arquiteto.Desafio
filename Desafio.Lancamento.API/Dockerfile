#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["Desafio.Lancamento.API/Desafio.Lancamento.API.csproj", "Desafio.Lancamento.API/"]
RUN dotnet restore "Desafio.Lancamento.API/Desafio.Lancamento.API.csproj"
COPY . .
WORKDIR "/src/Desafio.Lancamento.API"
RUN dotnet build "Desafio.Lancamento.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Desafio.Lancamento.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Desafio.Lancamento.API.dll"]



