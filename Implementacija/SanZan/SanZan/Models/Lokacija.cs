using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Lokacija
    {
        [Key]
        public int IDLokacije { get; set; }
        [EnumDataType(typeof(Kanton))]
        public Kanton Kanton { get; set; }
        [EnumDataType(typeof(Grad))]
        public Grad Grad { get; set; } 
        [RegularExpression(@"([\d\w-\.]+\s)+[\d]+", ErrorMessage = "Adresa se sastoji od imena ulice i broja!")]
        public string Adresa { get; set; }
    }
}
