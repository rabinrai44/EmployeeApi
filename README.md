# EmployeeApi

It is a simple web API application to manage employees built using Asp.NET Core and EntityFramework Core.

## Main Features

- Retrieve Employees
- Retrieve Employee By ID
- Insert Employee
- Update Employe
- Delete Employee

## API ROUTES

| VERB     | URL                | Description                    |
| :------- | :----------------- | :----------------------------- |
| `GET`    | `api/employees`    | To retrieve all employees      |
| `GET`    | `api/employees/1`  | To retrieve employee by ID     |
| `POST`   | `api/employees`    | To create a new employee       |
| `PUT`    | `api/employees/id` | To update an existing employee |
| `DELETE` | `api/employees/id` | To delete an existing employee |

## Getting Started
Use these instructions to get the project up and running.

### Prerequisites
You will need the following tools:

* [Visual Studio Code or Visual Studio 2019](https://visualstudio.microsoft.com/vs/) (version 16.3 or later)
* [.NET Core SDK 3](https://dotnet.microsoft.com/download/dotnet-core/3.0)
 * [Node.js](https://nodejs.org/en/) (version 10 or later) with npm (version 6.11.3 or later)

### Setup and Contributes
Follow these steps to get your development environment set up:

  1. Clone the repository
  
  2. At the root directory, restore required packages by running:
      ```
     dotnet restore
     ```
     
  3. Next, build the solution by running:
     ```
     dotnet build
     ```
     
  4. Next, within the `\EmployeeApi` directory, launch the back end by running:
  	 ```
     dotnet run
     ```		
	 
  5. Launch [http://localhost:5000/api](http://localhost:5000/api) in your browser to view the API
  
  6. Make changes, add new features or fix a bug.
  
  7. Make first pull request.
  
  
## Technologies
* .NET Core 2.2 or latest
* ASP.NET Core latest
* Entity Framework Core latest
