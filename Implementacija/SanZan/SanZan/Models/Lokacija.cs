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
        public Kanton kanton { get; set; }
        public Grad grad { get; set; }
        public string adresa { get; set; }
    }
}
