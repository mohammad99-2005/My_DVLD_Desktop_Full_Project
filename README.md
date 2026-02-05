# MyDVLD_Project
# 🪪 DVLD - Driving & Vehicle License Department System

![License](https://img.shields.io/badge/License-MIT-green) ![Platform](https://img.shields.io/badge/Platform-Desktop-blue) ![Language](https://img.shields.io/badge/Language-C%23-purple) ![Database](https://img.shields.io/badge/Database-SQL%20Server-red)

## 📌 Overview
**DVLD (Driving & Vehicle License Department)** is a comprehensive, enterprise-level desktop application designed to manage the complete lifecycle of driving licenses. 

Unlike simple CRUD applications, this system is a **real-world simulation** of a government licensing authority. It enforces complex business rules, manages workflows, and ensures strict data integrity across multiple related modules. 

The primary goal of this project was to transition from "tutorial-based learning" to **building a production-ready system**, applying advanced concepts like Layered Architecture, Clean Code, and solid OOP principles.

---

## 🏗️ Architecture
The application is built using a **3-Tier Architecture** to ensure separation of concerns and maintainability:

1.  **Presentation Layer (PL):** Windows Forms handling UI logic, events, and user validation.
2.  **Business Logic Layer (BLL):** C# classes that contain the core business rules, calculations, and data processing.
3.  **Data Access Layer (DAL):** Handles communication with Microsoft SQL Server using **ADO.NET** for high-performance data operations.

---

## 🛠️ Technology Stack
* **Language:** C# (.NET Framework)
* **Database:** Microsoft SQL Server
* **Data Access:** ADO.NET (Raw SQL for performance and control)
* **UI Framework:** Windows Forms (WinForms)
* **Concepts Applied:**
    * Object-Oriented Programming (OOP)
    * Clean Architecture
    * Role-Based Access Control (RBAC)
    * Complex SQL Queries (Joins, Views, Stored Procedures)

---

## 🚀 Key Features & Modules

### 👤 1. People & User Management
* Full profile management (Add, Edit, Delete, View).
* **User Authentication:** Secure login system with hashing and permission management.
* Filtering and searching capabilities across thousands of records.

### 🚗 2. Driving Licenses (Local & International)
* **Issuance:** Workflows for issuing new Local and International licenses.
* **Renewal:** Automated checks for license expiration and renewal eligibility.
* **Replacement:** Handling lost or damaged license replacements with audit trails.

### 📝 3. Applications & Tests
* **Application Types:** Manages fees and rules for different service types (New, Retake, Renewal).
* **Test Management:** Scheduling and recording results for Vision, Written, and Practical driving tests.
* **Business Rules:** Enforces strict rules (e.g., *User cannot retake a test if they passed previously*, *Cannot apply for a license if one is already active*).

### 👮 4. Detain & Release Licenses
* System to detain licenses for traffic violations.
* Payment processing and release workflows.
* Detailed history of all detained/released licenses.

---

## 🧠 What I Learned
Through building DVLD, I mastered:
* How to translate **real-world requirements** into database schemas and C# classes.
* Designing a **scalable database** with proper relationships (PK/FK) and normalization.
* Implementing **complex business logic** inside a dedicated layer, keeping the UI clean.
* Managing **application state** and user sessions securely.
* Writing **clean, reusable code** that is easy to debug and extend.

