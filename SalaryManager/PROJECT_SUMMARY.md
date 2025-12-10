# 💰 Salary Manager - C# Web Application

A complete, production-ready ASP.NET Core web application for managing employee salaries with interactive data visualization.

## ✨ What's Included

### Core Features
✅ **Employee Management** - Full CRUD operations (Create, Read, Update, Delete)
✅ **Salary Tracking** - Base salary, bonuses, and total compensation
✅ **Department Organization** - Categorize employees by department
✅ **Interactive Analytics** - 4 professional charts with real-time data
✅ **Responsive Design** - Works on desktop, tablet, and mobile
✅ **Data Persistence** - SQLite database with automatic seeding

### Components
- **5 Sample Employees** - Pre-loaded sample data across 5 departments
- **Bootstrap 5 UI** - Modern, responsive interface
- **Chart.js Integration** - Professional data visualization
- **Entity Framework Core** - Object-relational mapping
- **RESTful APIs** - Backend endpoints for chart data

## 📂 Project Structure

```
SalaryManager/
├── Controllers/
│   ├── HomeController.cs      # Dashboard
│   └── EmployeesController.cs # CRUD + Analytics APIs
├── Models/
│   └── Employee.cs            # Data model with validation
├── Data/
│   └── SalaryContext.cs       # Database context with seed data
├── Views/
│   ├── Home/Index.cshtml      # Dashboard
│   ├── Employees/
│   │   ├── Index.cshtml       # Employee list
│   │   ├── Create.cshtml      # Add employee form
│   │   ├── Edit.cshtml        # Edit employee form
│   │   ├── Details.cshtml     # Employee details
│   │   ├── Delete.cshtml      # Delete confirmation
│   │   └── Analytics.cshtml   # Charts dashboard
│   └── Shared/_Layout.cshtml  # Master template
├── wwwroot/
│   ├── css/site.css           # Custom styles
│   └── js/site.js             # JavaScript utilities
├── Program.cs                 # Application configuration
├── SalaryManager.csproj        # Project file
├── README.md                  # Full documentation
├── QUICKSTART.md              # Quick start guide
└── .vscode/                   # VS Code configuration
    ├── launch.json            # Debug configuration
    └── tasks.json             # Build tasks
```

## 🚀 Getting Started

### Prerequisite
- .NET 8 SDK or later installed

### Launch Command
```bash
cd "/home/nico/Dev/t/C# web/SalaryManager"
dotnet run
```

Open browser to:
- **HTTP**: http://localhost:5000
- **HTTPS**: https://localhost:5001

### VS Code Launch
- Press `F5` to debug
- Press `Ctrl+F5` to run without debugging

## 📊 Analytics Dashboard

Four interactive charts:

1. **Average Salary by Department** (Bar Chart)
   - Shows average compensation per department
   - Compare department budgets

2. **Employees by Department** (Pie Chart)
   - Distribution of workforce
   - Department size at a glance

3. **Employee Salary Comparison** (Bar Chart)
   - Individual salary overview
   - Base vs. total compensation

4. **Base Salary vs Total Salary** (Stacked Bar Chart)
   - Visualize bonus impact
   - See compensation breakdown

## 💻 Tech Stack

| Component | Technology |
|-----------|-----------|
| **Framework** | ASP.NET Core 8 |
| **Language** | C# |
| **Database** | SQLite |
| **ORM** | Entity Framework Core |
| **Frontend** | Razor Views, Bootstrap 5 |
| **Charts** | Chart.js |
| **API** | RESTful |

## 📝 Employee Data Model

```csharp
public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string Department { get; set; }
    public decimal BaseSalary { get; set; }
    public decimal BonusPercentage { get; set; }
    public decimal GetTotalSalary() { ... }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
}
```

## 🎯 Available Routes

| Route | Description |
|-------|-----------|
| `/` | Home dashboard |
| `/Employees/Index` | Employee list |
| `/Employees/Details/{id}` | Employee details |
| `/Employees/Create` | Create new employee |
| `/Employees/Edit/{id}` | Edit employee |
| `/Employees/Delete/{id}` | Delete employee |
| `/Employees/Analytics` | Analytics dashboard |
| `/api/employees/salary-by-department` | API: Salary data |
| `/api/employees/salary-distribution` | API: Distribution data |
| `/api/employees/department-distribution` | API: Department data |

## 🔧 Configuration

### Database
- **Type**: SQLite
- **File**: `salary_manager.db` (auto-created)
- **Location**: Project root

### Development Settings
- **HTTP**: Port 5000
- **HTTPS**: Port 5001
- **Auto-seed**: Sample data on first run

### Custom Port
```bash
dotnet run --urls "https://localhost:5003;http://localhost:5002"
```

## 🎓 Sample Employees

| Name | Department | Base Salary | Bonus | Total |
|------|-----------|------------|-------|-------|
| John Doe | Engineering | $80,000 | 10% | $88,000 |
| Jane Smith | Marketing | $65,000 | 8% | $70,200 |
| Bob Johnson | Sales | $70,000 | 12% | $78,400 |
| Alice Williams | Engineering | $90,000 | 15% | $103,500 |
| Charlie Brown | HR | $60,000 | 5% | $63,000 |

## 🔄 Build & Deployment

### Development
```bash
dotnet run
```

### Build Release
```bash
dotnet publish -c Release -o ./publish
```

### Run Published Version
```bash
dotnet SalaryManager.dll
```

## 📚 Documentation

- **README.md** - Comprehensive documentation
- **QUICKSTART.md** - Quick start guide
- **CODE STRUCTURE** - Well-organized with clear separation of concerns

## 🐛 Troubleshooting

**Port in use?**
```bash
dotnet run --urls "https://localhost:5003;http://localhost:5002"
```

**Reset database?**
Delete `salary_manager.db` and restart

**Build failed?**
```bash
dotnet clean && dotnet restore && dotnet build
```

**HTTPS certificate?**
```bash
dotnet dev-certs https --trust
```

## 🎉 Features Showcase

✨ **Professional UI**
- Bootstrap 5 responsive design
- Modern card layouts
- Clear navigation

📊 **Data Visualization**
- Real-time chart updates
- Multiple chart types
- Color-coded departments

⚡ **Performance**
- Efficient database queries
- Optimized API endpoints
- Fast page loads

🔒 **Data Integrity**
- Input validation
- Entity validation rules
- Secure form submission

## 📖 Usage Guide

1. **View Salaries**: Navigate to Employees to see all salary data
2. **Add Employee**: Use "Add Employee" form to insert new records
3. **Edit Salary**: Click "Edit" to modify employee information
4. **Analyze Data**: Go to Analytics for comprehensive visualizations
5. **Sort Data**: Use sort buttons to organize by name, salary, or department

## 🎯 Next Steps

1. Run the application with `dotnet run`
2. Explore the dashboard and sample data
3. Add new employees through the web interface
4. View analytics to see visualizations
5. Customize departments or styling as needed

## 📞 Support

Check console output for detailed error messages when running in development mode.

---

**Ready to go!** 🚀 Your salary management application is fully set up and ready to run.
