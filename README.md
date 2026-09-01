<div align="center">

# 🏢 C# Enterprise Platform

![C#](https://img.shields.io/badge/C%23-12-239120?style=flat&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat&logo=dotnet&logoColor=white)
![License](https://img.shields.io/badge/License-MIT-green?style=flat)
![Status](https://img.shields.io/badge/Deployed-Azure-0089D6?style=flat&logo=microsoftazure&logoColor=white)

*Enterprise-grade ASP.NET Core API with Entity Framework and Azure integration*

</div>

---

## ✨ Features

- ASP.NET Core 8 Web API
- Entity Framework Core ORM
- Azure cloud integration
- JWT Authentication
- Role-based authorization
- SQL Server database
- Swagger/OpenAPI documentation
- Docker containerization
- Health checks & monitoring

## 🛠️ Tech Stack

![C#](https://img.shields.io/badge/C%23-12-239120?style=flat&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat&logo=dotnet&logoColor=white)
![SQL Server](https://img.shields.io/badge/SQL_Server-2022-CC2927?style=flat&logo=microsoftsqlserver&logoColor=white)
![Azure](https://img.shields.io/badge/Azure-0089D6?style=flat&logo=microsoftazure&logoColor=white)

## 🚀 Quick Start

```bash
# Clone repository
git clone https://github.com/Raphasha27/csharp-enterprise-platform.git
cd csharp-enterprise-platform

# Restore dependencies
dotnet restore

# Run application
dotnet run --project src/EnterprisePlatform.API
```

### Docker

```bash
docker-compose up --build
```

## 📡 API Endpoints

| Method | Endpoint | Description |
|--------|----------|-------------|
| `POST` | `/api/auth/register` | Register user |
| `POST` | `/api/auth/login` | User login |
| `GET` | `/api/resources` | List resources |
| `POST` | `/api/resources` | Create resource |
| `PUT` | `/api/resources/{id}` | Update resource |
| `DELETE` | `/api/resources/{id}` | Delete resource |

## 🏗️ Architecture

```
┌─────────────────┐
│   Client        │
└────────┬────────┘
         │
┌────────▼────────┐
│  ASP.NET Core   │
│  Web API        │
└────────┬────────┘
         │
┌────────▼────────┐
│  Entity         │
│  Framework      │
└────────┬────────┘
         │
┌────────▼────────┐
│  SQL Server     │
│  + Azure        │
└─────────────────┘
```

## 🌐 Live Demo

| Platform | URL |
|----------|-----|
| GitHub Pages | [raphasha27.github.io/csharp-enterprise-platform](https://raphasha27.github.io/csharp-enterprise-platform) |
| Docker Hub | [hub.docker.com/r/raphasha27/csharp-enterprise-platform](https://hub.docker.com/r/raphasha27/csharp-enterprise-platform) |

## 👤 Author

**raphasha27** — [GitHub](https://github.com/raphasha27)
