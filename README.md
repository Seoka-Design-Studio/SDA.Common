# SDA.Common

A reusable .NET Nuget Packages built by **Seoka Design Agency** for centralizing service configurations, validation, Azure integration, messaging, logging, and base models across microservices.

This package provides plug-and-play setup for:

- 🔄 AutoMapper
- 🚍 MassTransit
- ☁ Azure Clients (Blob Storage, Identity, CDN)
- 📝 Serilog Logging
- 📦 Postman Client Config
- 🧱 Base Models (`DataModelBase`, `ServiceModelBase`)
- ✔️ FluentValidation with Dependency Injection

---

## ✨ Features

- ✅ AutoMapper configuration profile
- ✅ MassTransit with default settings (In-Memory/RabbitMQ-ready)
- ✅ Azure Blob, Identity, and CDN client setup
- ✅ Serilog setup via `appsettings.json`
- ✅ Base data and service model classes
- ✅ FluentValidation and DI setup for validators
- ✅ Postman environment config support

---

## 🛠️ Installation

```bash
dotnet add package SDA.Common
