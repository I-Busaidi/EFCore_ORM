using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_ORM.Models
{
    public class Employee
    {
        [Key]
        public int SSN { get; set; }

        [Required]
        public string FirstName { get; set; }

        public string MidName { get; set; }

        [Required]
        public string LastName { get; set; }

        public DateTime Bdate { get; set; }

        [MaxLength(100)]
        public string Address { get; set; }

        public bool Gender { get; set; }

        [Range(500, 5000)]
        public double Salary { get; set; }

        [ForeignKey("Department")]
        public int Dno { get; set; }
        public virtual Department Department { get; set; }

        [ForeignKey("Supervisor")]
        public int Super_SSN { get; set; }
        public virtual Employee Supervisor { get; set; }

        [InverseProperty("Supervisor")]
        public virtual ICollection<Employee> Supervisees { get; set; }

        public virtual ICollection<Works_On> Works_OnProj { get; set; }

        public virtual ICollection<Dependent> Dependents { get; set; }
    }
}
