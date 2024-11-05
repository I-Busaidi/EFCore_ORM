﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore_ORM.Models
{
    [PrimaryKey(nameof(ESSN), nameof(Pno))]
    public class Works_On
    {
        [ForeignKey("Employee")]
        public int ESSN { get; set; }
        public virtual Employee Employee { get; set; }

        [ForeignKey("Project")]
        public int Pno { get; set; }
        public virtual Project Project { get; set; }

        public decimal Hours { get; set; }
    }
}
