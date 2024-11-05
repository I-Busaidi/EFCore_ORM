using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Azure.Core.Pipeline;
using EFCore_ORM.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore_ORM
{
    public class ApplicationDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(" Data Source=(local); Initial Catalog=OutsysCompany; Integrated Security=true; TrustServerCertificate=True ");
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> departments { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<Dept_Locations> Dept_Locations { get; set; }
        public DbSet<Works_On> Works_On { get; set; }
        public DbSet<Dependent> dependents { get; set; }
    }
}
