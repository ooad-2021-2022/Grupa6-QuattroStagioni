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
        public int IDKantona { get; set; }
        public int IDGrad { get; set; }
        public string adresa { get; set; }
    }
}
