Installation
- In your production folder run "dotnet restore"

- create a new file named "appsettings.json" in your production directory.
- update your app.settings.json file contents with:
    - {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
- 