Installation
- In your production folder run "dotnet restore"
- While in the production folder, install EF core packages by running the commands:
    - $ dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
    - $ dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0

- create a new file named "appsettings.json" in your production directory.
- update your app.settings.json file contents with:
    - {
    "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=[YOUR-DB-NAME];uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
    }
}
- 