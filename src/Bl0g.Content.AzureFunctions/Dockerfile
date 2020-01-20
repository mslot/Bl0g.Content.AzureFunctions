FROM mcr.microsoft.com/azure-functions/dotnet:2.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:2.1-stretch AS build
WORKDIR /src
COPY ["Bl0g.Content.AzureFunctions/Bl0g.Content.AzureFunctions.csproj", "Bl0g.Content.AzureFunctions/"]
RUN dotnet restore "Bl0g.Content.AzureFunctions/Bl0g.Content.AzureFunctions.csproj"
COPY . .
WORKDIR "/src/Bl0g.Content.AzureFunctions"
RUN dotnet build "Bl0g.Content.AzureFunctions.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Bl0g.Content.AzureFunctions.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENV AzureWebJobsScriptRoot=/app