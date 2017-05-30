FROM microsoft/aspnetcore-build:latest
COPY . /app
WORKDIR /app
RUN ["dotnet", "restore"]
RUN ["dotnet", "build"]
RUN ["dotnet", "ef", "migrations", "add", "InitalCreate"]
RUN ["dotnet", "ef", "database", "update"]
EXPOSE 80/tcp
CMD dotnet run --server.urls http://*:80