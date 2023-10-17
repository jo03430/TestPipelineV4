#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["TestPipelineV4/TestPipelineV4.csproj", "TestPipelineV4/"]
COPY ["TestPipelineV4.Domain/TestPipelineV4.Domain.csproj", "TestPipelineV4.Domain/"]
RUN dotnet restore "TestPipelineV4/TestPipelineV4.csproj"
COPY . .
WORKDIR "/src/TestPipelineV4"
RUN dotnet build "TestPipelineV4.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "TestPipelineV4.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "TestPipelineV4.dll"]