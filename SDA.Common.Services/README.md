## SDA.Common.Services

This library provides a robust foundation for defining and registering message consumers across your company's microservices architecture. Built on **MassTransit** with **RabbitMQ** support, this package is designed to facilitate scalable, event-driven architectures. It seamlessly integrates with **PostmarkServices**, **Azure Service Bus**, and other commonly used libraries for API development, ensuring smooth communication between services.

## Features:
- **Message Consumer Registration**: Easily define and register message consumers across microservices.
- **Postmark Integration**: Reliable email delivery integration with **Postmark**.
- **Azure Service Bus Support**: Seamless integration with **Azure Service Bus** for cloud-native event-driven messaging.
- **Built on MassTransit**: Leverage **MassTransit** with **RabbitMQ** support for scalable message handling.
- **Future-Ready**: Designed to integrate smoothly into **Azure-hosted .NET 8 microservices**.

## Benefits:
- **Scalable and High-Performance**: Designed for reliable, high-performance message handling.
- **Asynchronous Workflow**: Supports event-driven architecture for flexible, non-blocking processing.
- **Cloud-Native**: Optimized for integration with **Azure-hosted** .NET 8 microservices.

## Ideal For:
- Building flexible, asynchronous, and event-driven APIs.
- Microservices-based architectures that need reliable communication between services.
- Companies transitioning to or building on **Azure-hosted .NET 8 microservices**.

## Usage:
1. Install the NuGet package to your .NET 8 microservice project.
2. Define message consumers for various events within your microservices.
3. Configure your message bus with **MassTransit** and integrate with **RabbitMQ**, **Postmark**, and **Azure Service Bus**.
4. Start building scalable, event-driven workflows in your application.

## Installation:

```bash
dotnet add package YourPackageName
