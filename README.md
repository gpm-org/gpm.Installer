# gpm.Installer
 
An auto-installer service for desktop apps. gpm.Installer uses <https://github.com/gpm-org/gpm> as backing registry.

The manager registry is located at <https://github.com/gpm-org/gpm-db> and accepts pull requests.

## Installation

gpm.Installer is available on nuget.org: 

You can use the following command in the Package Manager Console:
```ps
Install-Package gpm.Installer
```

| Package | NuGet Stable | NuGet Pre-release | Downloads |
| ------- | ------------ | ----------------- | --------- |
| [gpm.Installer](https://www.nuget.org/packages/gpm.Installer/) | [![gpm.Installer](https://img.shields.io/nuget/v/gpm.Installer.svg)](https://www.nuget.org/packages/gpm.Installer/) | [![gpm.Installer](https://img.shields.io/nuget/vpre/gpm.Installer.svg)](https://www.nuget.org/packages/gpm.Installer/) | [![gpm.Installer](https://img.shields.io/nuget/dt/gpm.Installer)](https://www.nuget.org/packages/gpm.Installer/) |

## Prerequisites

git must be installed on your PATH.

## Usage

1. Register gpm.Installer with your DI container. gpm.Installer 
```
services.AddGpmInstaller();
```

2. Build the auto-updater configuration, where `_autoInstallerService` is injected via Dependency Injection.
```
private void InitUpdateService() => _autoInstallerService
               .UseWPF()
               .AddVersion("<CURRENT APP VERSION>")
               .AddChannel("<CHANNEL NAME 1>", "<GPM ID 1>")
               .AddChannel("<CHANNEL NAME 2>", "<GPM ID 2>")
               .UseChannel("<CHANNEL NAME 1>")
               .Build();
```

## Contributing

Do you want to contribute? Community feedback and contributions are highly appreciated!

**For general rules and guidelines see [Contributing](/docs/Contributing.md).**
