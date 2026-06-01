# 🚀 3-Tier CRUD Operations Generator

A dynamic desktop automation utility built in C# using Windows Forms and .NET. This tool simplifies enterprise software development by automatically generating a complete, decoupled **Business Logic Layer (BLL)** and **Data Access Layer (DAL)** for Microsoft SQL Server database entities. It outputs production-ready, asynchronous C# files that implement the repository pattern and utilize Data Transfer Objects (DTO) to safely transport memory blocks across layer boundaries.

---

## 🏛️ Architecture Overview

The generator itself strictly follows a **3-Tier Architecture** to ensure a clean separation of concerns, maintainability, and scalability:

* **Presentation Layer (`CRUD_OperationsGenerator`)**: A responsive Windows Forms UI that captures server connections, handles database schema configurations, manages local grid inputs, and triggers the output creation[cite: 1, 2].
* **Business Logic Layer (`CRUD_OperationsGeneratorBusiness`)**: Contains the parsing templates, configuration models, and string interpolation builders (`GenerateDataLayer`, `GenerateBusinessLayer`) that dynamically turn column metadata into clean C# classes[cite: 3, 4].
* **Data Access Layer (`CRUD_OperationsGeneratorData`)**: Communicates with the configuration framework and queries SQL Server system metadata views asynchronously (`sys.databases`) to discover available databases on the instance[cite: 8, 9].

---

## ✨ Key Features

* **📦 Asynchronous Operation Architecture**: All database discovery operations and generated templates leverage modern `async/await` tasks to ensure non-blocking UI experiences[cite: 1, 4, 9].
* **⚙️ Automated 3-Tier Code Generation**: Generates two distinct, enterprise-standard architecture files directly to your desktop[cite: 4]:
  * `cls[TableName]Data.cs` — The Data Access Layer containing clean, parameterized ADO.NET CRUD operations using stored procedures[cite: 4].
  * `cls[TableName].cs` — The Business Logic Layer providing an intuitive, state-based `SaveAsync()`, `FindAsync()`, and `DeleteAsync()` interface[cite: 4].
* **🔄 Robust DTO Integration**: Automatically injects Data Transfer Objects (DTO) into the execution line to decouple business domain models from raw database records[cite: 4].
* **🛡️ Secure SQL Parameter Binding**: Generated templates construct explicit SQL command parameter assignments to guarantee structural protection against SQL Injection risks[cite: 4, 7].
* **📝 Dynamic SQL Nullability Handling**: Gracefully transforms relational system data, safely mapping database `DBNull.Value` states to standard C# native defaults (such as empty strings)[cite: 4, 7].
* **🛑 Advanced UI Validation**: Employs WinForms `ErrorProvider` infrastructure to parse text inputs, enforcing correct formatting boundaries before initiating class generation[cite: 2].

---

## 🛠️ Built With

| Component | Technology | Description |
| :--- | :--- | :--- |
| **Language** | C# 10+ / .NET | Modern object-oriented logic ecosystem |
| **Framework** | Windows Forms (WinForms) | Desktop UI interface management[cite: 1, 2] |
| **Database** | Microsoft SQL Server | Relational storage engine target |
| **Data Provider** | `Microsoft.Data.SqlClient` | Asynchronous ADO.NET data streaming[cite: 4, 9] |
| **Configuration** | `Microsoft.Extensions.Configuration` | JSON-based application setting loader |

---

## 📂 Project Structure

```hlb
├── CRUD_OperationsGenerator/          # Presentation Layer (UI Windows Forms)
│   ├── frmLogin.cs                     # Server authentication & database selection[cite: 1]
│   └── frmMain.cs                      # Schema definition grid & generation controls[cite: 2]
│
├── CRUD_OperationsGeneratorBusiness/  # Business Logic Layer (BLL)
│   ├── clsGenerateCRUD.cs              # Orchestrates code template output streaming[cite: 4]
│   ├── clsColumn.cs                    # Model representing database column metadata[cite: 3]
│   ├── clsGlobal.cs                    # Transient execution state configuration[cite: 5]
│   └── clsUtility.cs                   # Helper for SQL parameter parsing & formatting[cite: 7]
│
└── CRUD_OperationsGeneratorData/      # Data Access Layer (DAL)
    ├── clsAppConfigurations.cs         # Appsettings.json configuration loader[cite: 8]
    └── clsLoginInformations.cs         # Queries schema metadata from target instance[cite: 9]