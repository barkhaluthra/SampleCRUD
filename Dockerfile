FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

COPY . .

# 👉 Move into project folder (IMPORTANT)
WORKDIR /src/SampleCRUD

RUN dotnet restore
RUN dotnet publish -c Release -o /app

FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

COPY --from=build /app .

ENTRYPOINT ["dotnet", "SampleCRUD.dll"