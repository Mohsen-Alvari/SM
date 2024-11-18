This repository contains a Medication Management System developed using .NET Core with a code-first approach and implemented using the Onion architecture to ensure maintainability, scalability, and separation of concerns.

Technologies Used
.NET Core 8
Entity Framework Core (for code-first database migrations)
MediatR (for request/response and CQRS pattern)
SQL Server (default database)
Swashbuckle/Swagger (for API documentation)

Getting Started
To run this project locally, follow these steps:

Prerequisites
.NET SDK installed on your development machine
SQL Server instance (local or cloud-based)
Git for version control

Set up the database connection:

Open appsettings.json in the BCC.Endpoints project.
Replace the existing ConnectionStrings section with your SQL Server connection string:
json
Copy code
"ConnectionStrings": {
  "MedicationConnection": "Server=YOUR_SERVER_NAME;Database=MedicationDB;User Id=YOUR_USER;Password=YOUR_PASSWORD;"
}
Run database migrations: Use the following commands to create the database and apply migrations:

bash
Copy code
dotnet ef database update --project BCC.Infrastructure --startup-project BCC.Endpoints
Run the application:

bash
Copy code
dotnet run --project BCC.Endpoints
The Swagger UI should be accessible at https://localhost:5001/swagger for API testing and documentation.

Project Architecture
This project follows the Onion architecture, which emphasizes:

Separation of Concerns: Dividing the project into different layers with specific responsibilities.
Dependency Inversion: The core of the application does not depend on external frameworks or data access layers.
Maintainability: Facilitates easy modifications and extensions.
Layers
Core (Domain Layer): Contains business logic, entity definitions, and core interfaces.
Application Layer: Handles commands, queries, and other application logic using MediatR.
Infrastructure Layer: Implements data access using Entity Framework Core and connects to external resources.
Presentation Layer (Endpoints): Exposes RESTful API controllers for interacting with the application.
