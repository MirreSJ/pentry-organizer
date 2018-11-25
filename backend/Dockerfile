FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ./src .
RUN dotnet restore
RUN dotnet build --no-restore -c Release -o /app

FROM build AS test
RUN dotnet test

FROM build AS publish
WORKDIR ./pentry
RUN dotnet publish "pentry.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "pentry.dll"]