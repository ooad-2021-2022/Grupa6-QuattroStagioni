using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Zahtjev
    {
        [Key, ForeignKey("ZahtjevTagovi")]
        public int IDZahtjeva { get; set; }
        [ForeignKey("Korisnik")]
        public int IDKlijenta { get; set; }
        public DateTime vrijemeZahtjeva { get; set; }
        public int djelatnost { get; set; }
        [ForeignKey("Lokacija")]
        public int lokacija { get; set; }
}
}
