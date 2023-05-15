FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-buster-slim AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/core/sdk:3.1-buster AS build
WORKDIR /src
COPY ["src/C.Estudo.Events.EmailService/C.Estudo.Events.EmailService.csproj", "src/C.Estudo.Events.EmailService/"]
RUN dotnet restore "src/C.Estudo.Events.EmailService/C.Estudo.Events.EmailService.csproj"
COPY . .
WORKDIR "/src/src/C.Estudo.Events.EmailService"
RUN dotnet build "C.Estudo.Events.EmailService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "C.Estudo.Events.EmailService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "C.Estudo.Events.EmailService.dll"]