using Microsoft.EntityFrameworkCore;
using SalaryManager.Models;

namespace SalaryManager.Data
{
    public class SalaryContext : DbContext
    {
        public SalaryContext(DbContextOptions<SalaryContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employees { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configure Employee entity
            modelBuilder.Entity<Employee>()
                .Property(e => e.BaseSalary)
                .HasColumnType("REAL");

            modelBuilder.Entity<Employee>()
                .Property(e => e.BonusPercentage)
                .HasColumnType("REAL");

            // Add seed data
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    Email = "john.doe@example.com",
                    Department = "Engineering",
                    BaseSalary = 80000,
                    BonusPercentage = 10,
                    CreatedDate = DateTime.UtcNow
                },
                new Employee
                {
                    Id = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    Email = "jane.smith@example.com",
                    Department = "Marketing",
                    BaseSalary = 65000,
                    BonusPercentage = 8,
                    CreatedDate = DateTime.UtcNow
                },
                new Employee
                {
                    Id = 3,
                    FirstName = "Bob",
                    LastName = "Johnson",
                    Email = "bob.johnson@example.com",
                    Department = "Sales",
                    BaseSalary = 70000,
                    BonusPercentage = 12,
                    CreatedDate = DateTime.UtcNow
                },
                new Employee
                {
                    Id = 4,
                    FirstName = "Alice",
                    LastName = "Williams",
                    Email = "alice.williams@example.com",
                    Department = "Engineering",
                    BaseSalary = 90000,
                    BonusPercentage = 15,
                    CreatedDate = DateTime.UtcNow
                },
                new Employee
                {
                    Id = 5,
                    FirstName = "Charlie",
                    LastName = "Brown",
                    Email = "charlie.brown@example.com",
                    Department = "HR",
                    BaseSalary = 60000,
                    BonusPercentage = 5,
                    CreatedDate = DateTime.UtcNow
                }
            );
        }
    }
}
