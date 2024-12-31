FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["src/Untill.Api/Untill.Api.csproj", "Untill.Api/"]
COPY ["src/Untill.Application/Untill.Application.csproj", "Untill.Application/"]
COPY ["src/Untill.Domain/Untill.Domain.csproj", "Untill.Domain/"]
COPY ["src/Untill.Contracts/Untill.Contracts.csproj", "Untill.Contracts/"]
COPY ["src/Untill.Infrastructure/Untill.Infrastructure.csproj", "Untill.Infrastructure/"]
COPY ["Directory.Packages.props", "./"]
COPY ["Directory.Build.props", "./"]
RUN dotnet restore "Untill.Api/Untill.Api.csproj"
COPY . ../
WORKDIR /src/Untill.Api
RUN dotnet build "Untill.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish --no-restore -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0
ENV ASPNETCORE_HTTP_PORTS=5001
EXPOSE 5001
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Untill.Api.dll"]