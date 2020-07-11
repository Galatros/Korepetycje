@echo off
echo Adding migration: %1
dotnet ef migrations add %1 -c LibraryDbContext -p SolidApi.Repository/SolidApi.Repository.csproj -s SolidApi/SolidApi.csproj -o Data/Migrations
set /p DUMMY=Hit ENTER to continue...