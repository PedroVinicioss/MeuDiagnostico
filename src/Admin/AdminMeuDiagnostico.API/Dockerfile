FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY . .
RUN dotnet restore "src/Admin/AdminMeuDiagnostico.API/AdminMeuDiagnostico.API.csproj"
RUN dotnet build "src/Admin/AdminMeuDiagnostico.API/AdminMeuDiagnostico.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "src/Admin/AdminMeuDiagnostico.API/AdminMeuDiagnostico.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AdminMeuDiagnostico.API.dll"]
