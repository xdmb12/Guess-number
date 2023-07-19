FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["GuessNumber/GuessNumber.csproj", "GuessNumber/"]
RUN dotnet restore "GuessNumber/GuessNumber.csproj"
COPY . .
WORKDIR "/src/GuessNumber"
RUN dotnet build "GuessNumber.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "GuessNumber.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "GuessNumber.dll"]
