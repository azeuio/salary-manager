# Salary Manager - Quick Start Guide

## 🚀 Quick Launch

### Option 1: Run from Terminal
```bash
cd "/home/nico/Dev/t/C# web/SalaryManager"
dotnet run
```

Then open your browser and navigate to:
- **HTTP**: `http://localhost:5000`
- **HTTPS**: `https://localhost:5001`

### Option 2: Run from VS Code
1. Open the project folder in VS Code
2. Press `F5` to start debugging (or Ctrl+F5 without debugging)
3. The browser will automatically open

### Option 3: Run with Custom Port
```bash
dotnet run --urls "https://localhost:5003;http://localhost:5002"
```

## 🎯 Features Overview

### Dashboard (Home Page)
- Summary statistics of all employees
- Quick stats: Total Employees, Average Salary, Total Payroll, Department Count
- Quick navigation links

### Employee Management
- **View Employees**: See all employees in a table with sorting options
- **Add Employee**: Create new employee records
- **Edit Employee**: Modify employee information
- **Delete Employee**: Remove employee records
- **View Details**: See comprehensive employee information

### Analytics Dashboard
Interactive charts and visualizations:
1. **Average Salary by Department** - Bar chart showing department averages
2. **Employees by Department** - Pie chart showing employee distribution
3. **Employee Salary Comparison** - Individual employee salary comparison
4. **Base Salary vs Total Salary** - Breakdown of base pay and bonuses

## 📊 Sample Data

The application comes with 5 sample employees:
- **John Doe** - Engineering - $80,000 (+ 10% bonus)
- **Jane Smith** - Marketing - $65,000 (+ 8% bonus)
- **Bob Johnson** - Sales - $70,000 (+ 12% bonus)
- **Alice Williams** - Engineering - $90,000 (+ 15% bonus)
- **Charlie Brown** - HR - $60,000 (+ 5% bonus)

## 🗄️ Database

- **Type**: SQLite
- **Location**: `salary_manager.db` (created automatically in project root)
- **Auto-Created**: Database and tables are created on first run
- **Seed Data**: Sample data is populated automatically

### Reset Database
To start fresh, simply delete `salary_manager.db` and run the application again.

## ⚙️ Technology Stack

- **.NET**: 8.0
- **Framework**: ASP.NET Core MVC
- **Database**: SQLite + Entity Framework Core
- **UI**: Bootstrap 5 + Chart.js
- **API**: RESTful endpoints for chart data

## 🔧 Build & Compile

```bash
# Restore packages
dotnet restore

# Build the project
dotnet build

# Run tests (if any)
dotnet test

# Publish for production
dotnet publish -c Release -o ./publish
```

## 🌐 Navigation

- **Home**: Dashboard with summary
- **Employees**: List all employees with sorting
- **Analytics**: Interactive charts and data visualizations
- **Add Employee**: Form to create new employee

## 📝 Employee Fields

When adding/editing employees:
- **First Name** (required)
- **Last Name** (required)
- **Email** (required, valid email format)
- **Department** (required, dropdown: Engineering, Marketing, Sales, HR, Finance)
- **Base Salary** (required, positive number)
- **Bonus Percentage** (0-100)

Total Salary = Base Salary + (Base Salary × Bonus % / 100)

## 🐛 Troubleshooting

### Port Already in Use
```bash
# Use different ports
dotnet run --urls "https://localhost:5003;http://localhost:5002"
```

### Certificate Warning
Run:
```bash
dotnet dev-certs https --trust
```

### Database Issues
Delete `salary_manager.db` and restart the application.

### Build Errors
```bash
# Clean and rebuild
dotnet clean
dotnet restore
dotnet build
```

## 📖 Project Structure

```
SalaryManager/
├── Controllers/           # Business logic
├── Models/               # Data models
├── Views/                # Razor templates
├── Data/                 # Database context
├── wwwroot/              # Static files (CSS, JS)
├── Program.cs            # Application startup
├── appsettings.json      # Configuration
└── SalaryManager.csproj   # Project file
```

## 🚦 Next Steps

1. Start the application with `dotnet run`
2. Add some employees through the web interface
3. View the Analytics dashboard to see charts
4. Experiment with sorting and filtering

Enjoy managing salaries! 💰
