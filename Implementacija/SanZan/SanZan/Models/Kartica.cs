using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Kartica
    {
        [Key]
        public int IDKartice { get; set; }
        [ForeignKey("Korisnik")]
        public int IDVlasnikaKartice { get; set; }
        [Required]
        public double IznosNaKartici { get; set; }
        [Required]
        public DateTime DatumIzdavanjaKartice { get; set; }
    }
}
