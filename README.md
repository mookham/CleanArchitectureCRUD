# 🏗 Clean Architecture CRUD (ASP.NET)

This is a **CRUD Web API** project built with **ASP.NET** following the **Clean Architecture** pattern.  
It demonstrates how to organize code with separation of concerns between **Domain**, **Application**, **Infrastructure**, and **WebApi** layers.

---

## 🚀 Features
- Create, Read, Update, Delete (**CRUD**) operations for **Todo** entity
- Follows **Clean Architecture** principles
- **Swagger / OpenAPI** documentation
- Ready to connect with **SQL Database** (PostgreSQL / SQL Server)

---

## 📦 Prerequisites
Make sure you have the following installed:
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- SQL Server or PostgreSQL
- Visual Studio / Rider / VS Code

---

## 📂 Project Structure
│── Domain/ # Entities (business models)
│── Application/ # Abstractions & services (business logic)
│── Infrastructure/ # Database context, persistence
│── WebApi/ # Controllers, Swagger, API layer
│── README.md # Project documentation
