FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["pentry/pentry.csproj", "pentry/"]
RUN dotnet restore "pentry/pentry.csproj"
COPY . .
WORKDIR "/src/pentry"
RUN dotnet build "pentry.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "pentry.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "pentry.dll"]