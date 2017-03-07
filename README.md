    mono .paket/paket.exe restore
    dotnet restore **/*.fsproj
    dotnet build **/*.fsproj
    dotnet run --project **/*.fsproj