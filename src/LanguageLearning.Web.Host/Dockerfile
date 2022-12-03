#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/LanguageLearning.Web.Host/LanguageLearning.Web.Host.csproj", "src/LanguageLearning.Web.Host/"]
COPY ["src/LanguageLearning.Web.Core/LanguageLearning.Web.Core.csproj", "src/LanguageLearning.Web.Core/"]
COPY ["src/LanguageLearning.Application/LanguageLearning.Application.csproj", "src/LanguageLearning.Application/"]
COPY ["src/LanguageLearning.Core/LanguageLearning.Core.csproj", "src/LanguageLearning.Core/"]
COPY ["src/LanguageLearning.EntityFrameworkCore/LanguageLearning.EntityFrameworkCore.csproj", "src/LanguageLearning.EntityFrameworkCore/"]
RUN dotnet restore "src/LanguageLearning.Web.Host/LanguageLearning.Web.Host.csproj"
COPY . .
WORKDIR "/src/src/LanguageLearning.Web.Host"
RUN dotnet build "LanguageLearning.Web.Host.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LanguageLearning.Web.Host.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LanguageLearning.Web.Host.dll"]