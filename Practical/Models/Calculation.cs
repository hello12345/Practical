using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static Practical.Helper.EnumsCollection;

namespace Practical.Models
{
    public class Calculation
    {
        [Required]
        [Range(0, 1,ErrorMessage = "Value must be between 0 and 1")]
        public decimal value1 { get; set; }
        [Required]
        [Range(0, 1,ErrorMessage = "Value must be between 0 and 1")]
        public decimal value2 { get; set; }
        public decimal result { get; set; }
        [Required]
        public MethodType CalculationType { get; set; }
    }
}
