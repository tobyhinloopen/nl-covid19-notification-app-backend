# exposure key sets Generator

This runs creates exposure key sets (currently cuckoo filters) from the authorised Workflows in the database.

1. Download dotnet SDK: https://dotnet.microsoft.com/download/dotnet-core/3.1
1. Clone this repo
1. Choose your database
1. Add an `appsettings.Development.json` file. This overrides the settings in appsettings.json. And add a value for the MSS connection string.
1. Run the from the command line without building the project : dotnet run

NB. There is currently an outstanding issue running this on MacOS. It runs on Windows and Linux.