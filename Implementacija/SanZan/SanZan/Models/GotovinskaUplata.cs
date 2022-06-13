using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SanZan.Models
{
    public class GotovinskaUplata
    {
        [Key]
        public int IDUplate { get; set; }

        [ForeignKey("Korisnik")]
        public int IDKlijenta { get; set; }
        [ForeignKey("Korisnik")]
        public int IDDjelatnika { get; set; }
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Iznos uplate mora biti veći od 0")]
        [Display(Name = "Iznos uplate")]
        public double IznosUplate { get; set; }
    }
}
