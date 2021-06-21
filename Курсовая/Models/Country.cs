using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace CalculatorProject.Models
{
    public class Country
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Code { get; set; }

        public string Name { get; set; }
    }
}
