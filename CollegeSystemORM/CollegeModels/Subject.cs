using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.CollegeModels
{
    public class Subject
    {
        [Key]
        public int Subject_Id { get; set; }

        [Required]
        public string Subject_Name { get; set; }

        [ForeignKey("Teacher")]
        public int Teacher_Id { get; set; }
        public virtual Faculty Teacher { get; set; }
    }
}
