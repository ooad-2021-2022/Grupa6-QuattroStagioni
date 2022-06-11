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
        public double iznosUplate { get; set; }
    }
}
