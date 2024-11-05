using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_ORM.Models
{
    public class Department
    {
        [Key]
        public int Dnumber { get; set; }

        [Required]
        public string Dname { get; set; }

        [ForeignKey("Manager")]
        public int Mgr_SSN { get; set; }
        public virtual Employee Manager { get; set; }

        public DateTime Mgr_StartDate { get; set; }

        [InverseProperty("Department")]
        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<Project> Projects { get; set; }

        public virtual ICollection<Dept_Locations> Dept_Locations { get; set; }
    }
}
