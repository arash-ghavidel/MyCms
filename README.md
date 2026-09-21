# ASP.NET MVC Content Management System

A web-based Content Management System (CMS) developed using **ASP.NET MVC, C#, Entity Framework, and SQL Server** as a hands-on software development project.

The project was built to practice and demonstrate core concepts of ASP.NET MVC application development, database-driven applications, layered architecture, authentication, authorization, and CRUD operations.

## Technologies

* C#
* ASP.NET MVC
* .NET Framework
* Entity Framework
* SQL Server
* Razor
* HTML
* CSS
* JavaScript
* Bootstrap

## Features

* Content management
* Create, read, update, and delete (CRUD) operations
* User authentication
* Authorization based on authentication status
* Public content viewing for unauthenticated users
* Administrative access for authenticated users
* Database integration using Entity Framework
* Server-side validation
* MVC architecture
* Separation of data access logic from the main MVC application

## Access Control

The application uses a simple authentication-based access control model:

* **Unauthenticated users:** Can browse and view available content.
* **Authenticated users:** Have access to the administrative functionality and can create, edit, and delete content.

This approach demonstrates the use of authentication and authorization within an ASP.NET MVC application without implementing a multi-role permission system.

## Project Structure

The solution is organized into separate projects to keep the main MVC application and data access responsibilities separated.

```text
MyCms
│
├── MyCms
│   ├── Controllers
│   ├── Models
│   ├── Views
│   └── ...
│
└── DataLayer
    ├── Data Access
    ├── Entity Models
    └── ...
```

## Architecture

The application follows the **Model-View-Controller (MVC)** architectural pattern.

The data access functionality is separated into a dedicated `DataLayer` project, helping keep database-related responsibilities separate from the main web application.

```text
Browser
   │
   ▼
Controllers
   │
   ▼
Application Logic
   │
   ▼
DataLayer
   │
   ▼
Entity Framework
   │
   ▼
SQL Server
```

## Database

The application uses **Microsoft SQL Server** as its relational database and **Entity Framework** for database access and object-relational mapping.

> Database connection settings should be configured locally before running the application.

## Getting Started

### Prerequisites

Before running the project, make sure you have:

* Visual Studio
* .NET Framework compatible with the project
* SQL Server
* SQL Server Management Studio (optional)

### Installation

1. Clone the repository:

```bash
git clone https://github.com/arash-ghavidel/MyCms.git
```

2. Open the solution in Visual Studio.

3. Configure the SQL Server connection string in the application's configuration file.

4. Create or restore the required database.

5. Build the solution.

6. Run the application using Visual Studio.

## What I Practiced

This project was developed as part of my practical learning journey in .NET development.

Through this project, I practiced:

* ASP.NET MVC application development
* C# object-oriented programming
* Entity Framework
* SQL Server database integration
* MVC architecture
* Authentication and authorization
* CRUD operations
* Layered application structure
* Working with Razor Views
* Git and GitHub version control

## Future Improvements

Possible future improvements include:

* Migrating the application to ASP.NET Core
* Improving the UI/UX
* Adding automated tests
* Improving application security
* Introducing dependency injection more extensively
* Adding a RESTful API
* Containerizing the application with Docker

## Author

**Arash Ghavidel**

Computer Engineer | .NET & Python Developer

GitHub: https://github.com/arash-ghavidel
