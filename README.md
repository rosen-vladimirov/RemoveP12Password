# RemoveP12Password
Contains the code and executable required to remove password from p12 file.

## Usage
1. Download the latest release from the repository and based on your OS.
2. Open command-prompt/terminal and execute the following:
```
RemoveP12Password <infile> <current password> <outfile>
```

For example:
```
RemoveP12Password myCert.p12 myPass myCertWithoutPass.p12
```

## Build on your own
In case you want to build the application on your own, you can just download the .NET Core SDK and command line from [here](https://dotnet.microsoft.com/download/dotnet-core/scripts).
After that, inside the RemoveP12Password inner dir, just execute:
```
dotnet build
```
This will build the app in debug and you'll be able to find the executable in the bin directory.


## Publishing
All of the releases are published with the commands:
- macOS:
```
dotnet publish -r osx-x64 -c Release /p:PublishSingleFile=true
```
- Windows:
```
dotnet publish -r win-x64 -c Release /p:PublishSingleFile=true
```
- Linux:
```
dotnet publish -r linux-x64 -c Release /p:PublishSingleFile=true
```