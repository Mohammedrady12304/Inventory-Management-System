# Inventory Management System

A desktop inventory and sales management application built with **C# (.NET 9), Windows Forms, and Entity Framework Core**, backed by **SQL Server**. It centralizes product, category, customer, and order management for a small retail business, with role-based login, a live dashboard, and printable invoices.

## Features

- **Authentication** — login screen with role-based access (`Admin` / `User`)
- **Dashboard** — real-time stats: total products, total customers, today's orders, and low-stock alerts (quantity below threshold)
- **Product management** — create, update, delete products, organized by category
- **Category management** — manage categories and browse products per category
- **Customer management** — maintain customer records and view each customer's order history
- **Order management** — create orders with line items, automatically calculated totals
- **Invoicing** — generate and print order invoices
- **User management** — admin-only screen for managing system users and roles

## Tech Stack

| Layer | Technology |
|---|---|
| UI | Windows Forms (.NET 9) |
| Data Access | Entity Framework Core 9 (Code-First + Migrations) |
| Database | SQL Server |
| Architecture | Class Library (models, repositories, interfaces) + WinForms presentation layer |
| Patterns | Repository pattern (`IBaseRepository<T>` / `BaseRepository<T>`) |

## Project Structure

```
InventoryManagementSystem/
├── ClassLibrary/              # Class Library project
│   ├── Context/                # EF Core DbContext
│   ├── Models/                 # User, Product, Category, Customer, Order, OrderItem
│   ├── Interfaces/             # IBaseRepository<T>
│   ├── Services/                # Repositories + DbInitializer (seed data)
│   └── Migrations/
├── Windows Forms/              # WinForms UI project
│   ├── Forms/                   # Login, Dashboard, Product, Category, Customer, Order, Invoice, User
│   ├── Helpers/
│   └── Properties/
└── InventoryManagementSystem.sln
```

## Data Model

The system tracks five core entities:
- **User** — `username`, `fullname`, `password`, `phone`, `role` (Admin/User)
- **Category** → has many **Products**
- **Product** — name, quantity, price, description, category
- **Customer** → has many **Orders**
- **Order** / **OrderItem** — order header with line items linking to products

## Getting Started

### Prerequisites
- .NET 9 SDK
- SQL Server (local or remote instance)
- Visual Studio 2022+ (recommended) or `dotnet` CLI

### Setup

1. Clone the repository:
   ```bash
   git clone https://github.com/Mohammedrady12304/Inventory-Management-System.git
   ```
2. Update the connection string if needed (defaults to a local SQL Server instance with Windows Authentication):
   ```
   Server=.;Database=InventoryManagementSystem;Integrated Security=True;TrustServerCertificate=True;
   ```
   Found in `ClassLibrary/Context/InventoryManagementContext.cs` and `Windows Forms/App.config`.
3. Apply EF Core migrations to create the database:
   ```bash
   dotnet ef database update --project ClassLibrary --startup-project "Windows Forms"
   ```
4. Run the app (a default admin user — `admin` / `admin123` — is seeded on first run):
   ```bash
   dotnet run --project "Windows Forms"
   ```

## License

This project is for educational/portfolio purposes.
