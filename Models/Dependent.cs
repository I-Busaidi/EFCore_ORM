using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_ORM.Models
{
    [PrimaryKey(nameof(ESSN), nameof(DependentName))]
    public class Dependent
    {
        [ForeignKey("Employee")]
        public int ESSN { get; set; }
        public virtual Employee Employee { get; set; }

        [Required]
        public string DependentName { get; set; }

        public bool Gender { get; set; }

        public DateTime Bdate { get; set; }

        public string Relationship { get; set; }
    }
}
