@echo off
cd SolidApi.Repository
dotnet restore
dotnet ef database update %1 -c LibraryDbContext -s ..\SolidApi\SolidApi.csproj
cd ..
set /p DUMMY=Hit ENTER to continue...