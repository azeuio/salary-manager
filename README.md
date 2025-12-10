# Salary Manager

A modern ASP.NET Core web application for managing employee salaries and visualizing salary data with interactive charts and graphs.

## Features

- **Employee Management**: Add, edit, delete, and view employee records
- **Salary Tracking**: Track base salary, bonuses, and total compensation
- **Department Management**: Organize employees by department
- **Analytics Dashboard**: View comprehensive salary analytics with multiple chart types:
  - Average salary by department (bar chart)
  - Employee distribution by department (pie chart)
  - Individual employee salary comparison (bar chart)
  - Base salary vs. bonus breakdown (stacked bar chart)
- **Sorting & Filtering**: Sort employees by name, salary, or department
- **Responsive Design**: Bootstrap 5 for mobile-friendly interface

## Tech Stack

- **Framework**: ASP.NET Core 8
- **Database**: SQLite with Entity Framework Core
- **Frontend**: Razor views, Bootstrap 5, Chart.js
- **Language**: C#

## Project Structure

```
SalaryManager/
├── Models/
│   └── Employee.cs           # Employee model
├── Controllers/
│   ├── HomeController.cs     # Home page controller
│   └── EmployeesController.cs # Employee management & API
├── Views/
│   ├── Home/
│   │   └── Index.cshtml      # Dashboard
│   ├── Employees/
│   │   ├── Index.cshtml      # Employee list
│   │   ├── Details.cshtml    # Employee details
│   │   ├── Create.cshtml     # Add new employee
│   │   ├── Edit.cshtml       # Edit employee
│   │   ├── Delete.cshtml     # Delete confirmation
│   │   └── Analytics.cshtml  # Analytics dashboard with charts
│   └── Shared/
│       ├── _Layout.cshtml    # Master layout
│       └── _ValidationScriptsPartial.cshtml
├── Data/
│   └── SalaryContext.cs      # Database context with seed data
├── wwwroot/
│   ├── css/
│   │   └── site.css          # Custom styles
│   └── js/
│       └── site.js           # JavaScript utilities
└── Program.cs               # Application startup configuration
```

## Getting Started

### Prerequisites

- .NET 8 SDK or later
- A terminal/command prompt

### Installation

1. Navigate to the project directory:
```bash
cd /home/nico/Dev/t/C#\ web/SalaryManager
```

2. Restore NuGet packages:
```bash
dotnet restore
```

3. Build the project:
```bash
dotnet build
```

## Running the Application

### Development Mode

```bash
dotnet run
```

The application will start at `https://localhost:5001` and `http://localhost:5000`.

### Production Build

```bash
dotnet publish -c Release -o ./publish
```

## Database

The application uses SQLite for persistence. On first run, the database is automatically created with seed data including 5 sample employees across different departments (Engineering, Marketing, Sales, HR).

- **Database File**: `salary_manager.db` (created in the project root)
- **Seed Data**: Includes 5 sample employees with various salaries and bonuses

## API Endpoints

The application provides REST API endpoints for chart data:

- `GET /api/employees/salary-by-department` - Average salary by department
- `GET /api/employees/salary-distribution` - Individual employee salaries
- `GET /api/employees/department-distribution` - Employee count by department

## Usage

1. **Home Dashboard**: View summary statistics of all employees
2. **Employees List**: View all employees with sorting options
3. **Add Employee**: Create a new employee record
4. **Edit Employee**: Update employee information
5. **Employee Details**: View comprehensive employee information
6. **Analytics Dashboard**: View interactive salary charts and graphs

## Employee Model Fields

- **First Name**: Employee's first name
- **Last Name**: Employee's last name
- **Email**: Employee's email address
- **Department**: Department assignment (Engineering, Marketing, Sales, HR, Finance)
- **Base Salary**: Base annual salary
- **Bonus Percentage**: Bonus percentage applied to base salary
- **Total Salary**: Calculated as Base Salary + (Base Salary × Bonus %)

## Chart Visualizations

### Analytics Dashboard Charts

1. **Average Salary by Department**: Bar chart showing average salary for each department
2. **Employees by Department**: Pie chart showing distribution of employees
3. **Employee Salary Comparison**: Bar chart comparing individual employee salaries
4. **Base Salary vs Total Salary**: Stacked bar chart showing base vs bonus breakdown

## Customization

### Adding New Departments

Edit the department dropdown in `Views/Employees/Create.cshtml` and `Views/Employees/Edit.cshtml`:

```html
<option value="YourDepartment">Your Department</option>
```

### Modifying Seed Data

Edit `Data/SalaryContext.cs` to change or add sample employees on startup.

### Styling

Customize colors and styles in `wwwroot/css/site.css`.

## Troubleshooting

### Port Already in Use
If port 5000/5001 is in use, specify a different port:
```bash
dotnet run --urls "https://localhost:5003;http://localhost:5002"
```

### Database Issues
To reset the database, delete `salary_manager.db` and run the application again.

## Future Enhancements

- User authentication and authorization
- Department management CRUD
- Salary history and tracking
- Export reports (PDF, Excel)
- Advanced filtering and search
- Salary review workflows
- Performance ratings integration

## Screenshots
# Salary Manager

A modern ASP.NET Core web application for managing employee salaries and visualizing salary data with interactive charts and graphs.

## Features

- **Employee Management**: Add, edit, delete, and view employee records
- **Salary Tracking**: Track base salary, bonuses, and total compensation
- **Department Management**: Organize employees by department
- **Analytics Dashboard**: View comprehensive salary analytics with multiple chart types:
  - Average salary by department (bar chart)
  - Employee distribution by department (pie chart)
  - Individual employee salary comparison (bar chart)
  - Base salary vs. bonus breakdown (stacked bar chart)
- **Sorting & Filtering**: Sort employees by name, salary, or department
- **Responsive Design**: Bootstrap 5 for mobile-friendly interface

## Tech Stack

- **Framework**: ASP.NET Core 8
- **Database**: SQLite with Entity Framework Core
- **Frontend**: Razor views, Bootstrap 5, Chart.js
- **Language**: C#

## Project Structure

```
SalaryManager/
├── Models/
│   └── Employee.cs           # Employee model
├── Controllers/
│   ├── HomeController.cs     # Home page controller
│   └── EmployeesController.cs # Employee management & API
├── Views/
│   ├── Home/
│   │   └── Index.cshtml      # Dashboard
│   ├── Employees/
│   │   ├── Index.cshtml      # Employee list
│   │   ├── Details.cshtml    # Employee details
│   │   ├── Create.cshtml     # Add new employee
│   │   ├── Edit.cshtml       # Edit employee
│   │   ├── Delete.cshtml     # Delete confirmation
│   │   └── Analytics.cshtml  # Analytics dashboard with charts
│   └── Shared/
│       ├── _Layout.cshtml    # Master layout
│       └── _ValidationScriptsPartial.cshtml
├── Data/
│   └── SalaryContext.cs      # Database context with seed data
├── wwwroot/
│   ├── css/
│   │   └── site.css          # Custom styles
│   └── js/
│       └── site.js           # JavaScript utilities
└── Program.cs               # Application startup configuration
```

## Getting Started

### Prerequisites

- .NET 8 SDK or later
- A terminal/command prompt

### Installation

1. Navigate to the project directory:
```bash
cd /home/nico/Dev/t/C#\ web/SalaryManager
```

2. Restore NuGet packages:
```bash
dotnet restore
```

3. Build the project:
```bash
dotnet build
```

## Running the Application

### Development Mode

```bash
dotnet run
```

The application will start at `https://localhost:5001` and `http://localhost:5000`.

### Production Build

```bash
dotnet publish -c Release -o ./publish
```

## Database

The application uses SQLite for persistence. On first run, the database is automatically created with seed data including 5 sample employees across different departments (Engineering, Marketing, Sales, HR).

- **Database File**: `salary_manager.db` (created in the project root)
- **Seed Data**: Includes 5 sample employees with various salaries and bonuses

## API Endpoints

The application provides REST API endpoints for chart data:

- `GET /api/employees/salary-by-department` - Average salary by department
- `GET /api/employees/salary-distribution` - Individual employee salaries
- `GET /api/employees/department-distribution` - Employee count by department

## Usage

1. **Home Dashboard**: View summary statistics of all employees
2. **Employees List**: View all employees with sorting options
3. **Add Employee**: Create a new employee record
4. **Edit Employee**: Update employee information
5. **Employee Details**: View comprehensive employee information
6. **Analytics Dashboard**: View interactive salary charts and graphs

## Employee Model Fields

- **First Name**: Employee's first name
- **Last Name**: Employee's last name
- **Email**: Employee's email address
- **Department**: Department assignment (Engineering, Marketing, Sales, HR, Finance)
- **Base Salary**: Base annual salary
- **Bonus Percentage**: Bonus percentage applied to base salary
- **Total Salary**: Calculated as Base Salary + (Base Salary × Bonus %)

## Chart Visualizations

### Analytics Dashboard Charts

1. **Average Salary by Department**: Bar chart showing average salary for each department
2. **Employees by Department**: Pie chart showing distribution of employees
3. **Employee Salary Comparison**: Bar chart comparing individual employee salaries
4. **Base Salary vs Total Salary**: Stacked bar chart showing base vs bonus breakdown

## Customization

### Adding New Departments

Edit the department dropdown in `Views/Employees/Create.cshtml` and `Views/Employees/Edit.cshtml`:

```html
<option value="YourDepartment">Your Department</option>
```

### Modifying Seed Data

Edit `Data/SalaryContext.cs` to change or add sample employees on startup.

### Styling

Customize colors and styles in `wwwroot/css/site.css`.

## Troubleshooting

### Port Already in Use
If port 5000/5001 is in use, specify a different port:
```bash
dotnet run --urls "https://localhost:5003;http://localhost:5002"
```

### Database Issues
To reset the database, delete `salary_manager.db` and run the application again.

## Future Enhancements

- User authentication and authorization
- Department management CRUD
- Salary history and tracking
- Export reports (PDF, Excel)
- Advanced filtering and search
- Salary review workflows
- Performance ratings integration

## Screenshots

<img width="1920" height="1080" alt="Screenshot From 2025-12-10 12-17-07" src="https://github.com/user-attachments/assets/8a72f229-d47c-422b-929d-94cac45bdc05" />

## License

This project is provided as-is for educational and development purposes.

## Support

For issues or questions, please check the console output for detailed error messages when running in development mode.


## License

This project is provided as-is for educational and development purposes.

## Support

For issues or questions, please check the console output for detailed error messages when running in development mode.
