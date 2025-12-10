using System.ComponentModel.DataAnnotations;

namespace SalaryManager.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string LastName { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [StringLength(100)]
        public string Department { get; set; } = string.Empty;

        [Required]
        [Range(0, double.MaxValue)]
        public decimal BaseSalary { get; set; }

        [Range(0, 100)]
        public decimal BonusPercentage { get; set; }

        public decimal GetTotalSalary()
        {
            return BaseSalary + (BaseSalary * BonusPercentage / 100);
        }

        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedDate { get; set; }
    }
}
