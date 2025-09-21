# 🛒 .NET Microservices E-Commerce Project  

[![.NET 8](https://img.shields.io/badge/.NET-8.0-purple.svg)](https://dotnet.microsoft.com/)  
[![Entity Framework Core](https://img.shields.io/badge/EntityFrameworkCore-8.0-green)](https://learn.microsoft.com/ef/core/)  
[![Azure Service Bus](https://img.shields.io/badge/Azure-ServiceBus-blue)](https://azure.microsoft.com/services/service-bus/)  
[![Azure App Service](https://img.shields.io/badge/Azure-AppService-lightblue)](https://azure.microsoft.com/services/app-service/)  
[![Azure SQL Database](https://img.shields.io/badge/Azure-SQLDatabase-darkblue)](https://azure.microsoft.com/services/sql-database/)  
[![Ocelot Gateway](https://img.shields.io/badge/Ocelot-API%20Gateway-orange)](https://ocelot.readthedocs.io/)  
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](LICENSE)  

This repository contains an **E-Commerce application built with Microservices architecture** using **.NET 8**, developed as part of a Udemy course.  

The project demonstrates how to design and implement multiple microservices with **clean architecture**, **authentication & authorization**, **async messaging with Azure Service Bus**, and an **API Gateway with Ocelot**.  

---

## 🚀 Project Overview  

Traditional **monolithic applications** often face scalability, maintainability, and deployment challenges.  
This project showcases how to overcome these issues using **Microservices Architecture** in the .NET ecosystem.  

You’ll find **7 fully working microservices**, communication patterns (sync/async), and best practices for building robust enterprise-level applications.  

---

## 🧩 Microservices Implemented  

- **Product Microservice** – Manage products catalog  
- **Coupon Microservice** – Handle discount codes  
- **Shopping Cart Microservice** – Add/remove products from cart  
- **Order Microservice** – Manage customer orders  
- **Payment Microservice** – Process payments  
- **Email Microservice** – Send notifications/emails  
- **.NET Identity Microservice** – Authentication & Role-based Authorization  

### Supporting Projects
- **Ocelot API Gateway** – Entry point for client communication  
- **MVC Web Application** – Frontend built with ASP.NET Core MVC + Bootstrap 5  

---

## 🛠️ Tech Stack  

- **.NET 8** (APIs & MVC)  
- **Entity Framework Core** (SQL Server)  
- **Azure Service Bus** (Topics & Queues)  
- **Ocelot API Gateway**  
- **.NET Identity** (Authentication & Role-based Authorization)  
- **Swagger / OpenAPI** (API documentation)  
- **Clean Architecture + Repository Pattern**  
- **Bootstrap 5** (UI)  

---

## ☁️ Azure Cloud Deployment  

I also learned and implemented **Azure Cloud services** to deploy this project:  

- **Azure App Service** – Published the microservices and MVC Web App  
- **Azure SQL Database** – Hosted databases for each microservice  
- **Azure Service Bus** – Used for asynchronous communication between microservices  
- **CI/CD with Azure App Service** – Deployed directly from Visual Studio  

This gave me real-world experience in deploying and running microservices in a cloud environment.  

---

## 📚 What I Learned  

- Implementing **7 microservices** with .NET 8  
- Building **secure APIs** with Authentication & Authorization  
- Setting up **role-based access** using .NET Identity  
- Using **Azure Service Bus** for async communication  
- Implementing **Ocelot API Gateway** for routing & aggregation  
- Designing **layered architecture** with Repository Pattern  
- Writing **clean, maintainable, and scalable code**  
- Developing an **MVC web app** for the frontend  
- Deploying **microservices to Azure App Service**  
- Managing **databases with Azure SQL Database**  

---

## 📸 Architecture Overview  

```plaintext
[ MVC Web App ]
       |
 [ Ocelot Gateway ]
       |
---------------------------------------------------
|    Product    |   Cart   |   Order   |   Coupon |
|    Payment    |   Email  |   Identity            |
---------------------------------------------------
            |
     [ Azure Service Bus ]
            |
       [ Azure SQL Databases ]
