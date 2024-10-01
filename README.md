# Simple API with FastEndpoints and Slice Architecture

## 📄 Overview

This project is a simple API built using the [FastEndpoints](https://fast-endpoints.com/) NuGet package in **.NET 8**. The architecture follows the **Slice Architecture** pattern, where each feature of the system is isolated in its own slice, making the codebase more maintainable and scalable. The API is designed for rapid development with minimal overhead, focusing on clean and modular code.

## 🛠️ Technologies Used

- **.NET 8**  
- **FastEndpoints** - A lightweight .NET web framework designed to create fast and flexible HTTP APIs.  
- **Slice Architecture** - A feature-based architectural pattern that organizes code by feature (or slice) rather than by technical concern (e.g., controller, service, repository).  
- **Minimal APIs** - Simplified, minimal HTTP API creation using .NET's modern features.

## ✨ Features

- ✅ Fast and easy setup with FastEndpoints.  
- ✅ Modular codebase using slice architecture.  
- ✅ Built with .NET 8 for high performance.  
- ✅ Feature-focused code organization for scalability.

## 🏗️ Project Structure

This project uses **Slice Architecture**, which means that the code is organized by feature. Each slice represents a specific functionality or module of the application, encapsulating its own models, services, and endpoints.

### Structure aplyed

```plaintext

|-- Features/
    |-- Products/
        |-- Create/
            |-- Data.cs
            |-- Request.cs
            |-- Response.cs
            |-- Endpoint.cs
        |-- Delete/
        |-- GetAll/
        |-- GetById/
|-- Common/
    |-- Database/
    |-- Middleware/
|-- appsettings.json
|-- Globalusings.cs
|-- Programs.cs
