using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Poruka
    {
        [Key]
        public int IDPoruke { get; set; }
        [ForeignKey("Korisnik")]
        public int IDPrimaoca { get; set; }
        public Korisnik Primaoc { get; set; }
        [ForeignKey("Korisnik")]
        public int IDPosiljaoca { get; set;}
        public Korisnik Posiljaoc { get; set; }
        [Required]
        public DateTime Vrijeme { get; set; }
        [Required]
        public string Sadrzaj { get; set; }
    }
}
