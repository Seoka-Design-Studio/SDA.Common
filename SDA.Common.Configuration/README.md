# SDA.Common.Configuratio

This NuGet package extends Microsoft ASP.NET Core functionality by simplifying and centralizing configuration for common .NET libraries like AutoMapper, FluentValidation, and Serilog.

## Features

- **AutoMapper**
  - Auto-discovery and registration of mapping profiles
  - Extension methods for cleaner `IServiceCollection` configuration

- **FluentValidation**
  - Automatic validator registration
  - Integration with ASP.NET Core MVC

- **Serilog**
  - Structured logging configuration via `appsettings.json`
  - Built-in support for Console and MSSQL sinks
  - Easy setup with Serilog’s `IConfiguration` support

## Dependencies

This package wraps and configures the following libraries:

```xml
<ItemGroup>
  <PackageReference Include="AutoMapper" Version="13.0.1" />
  <PackageReference Include="FluentValidation.AspNetCore" Version="11.3.0" />
  <PackageReference Include="FluentValidation.DependencyInjectionExtensions" Version="11.11.0" />
  <PackageReference Include="Serilog.AspNetCore" Version="8.0.3" />
  <PackageReference Include="Serilog.Settings.Configuration" Version="8.0.4" />
  <PackageReference Include="Serilog.Sinks.Console" Version="6.0.0" />
  <PackageReference Include="Serilog.Sinks.MSSqlServer" Version="8.2.0" />
</ItemGroup>
```xml