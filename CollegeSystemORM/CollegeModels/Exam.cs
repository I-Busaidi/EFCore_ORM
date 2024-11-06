using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CollegeSystem.CollegeModels
{
    [PrimaryKey(nameof(Dept_Id), nameof(Exam_Code))]
    public class Exam
    {
        [ForeignKey("Department")]
        public int Dept_Id { get; set; }
        public virtual Department Department { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Exam_Code { get; set; }

        [Required]
        public int Room { get; set; }

        [Required]
        public DateOnly Date { get; set; }

        [Required]
        public TimeOnly Time { get; set; }
    }
}
