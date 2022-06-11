using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Korisnik
    {
        [Key, ForeignKey("Oglas")]
        public int IDKorisnika { get; set; }
        public string korisnickoIme { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string lozinka { get; set; }
        [ForeignKey("Kartica")]
        public int IDKartice { get; set; }
        public string brojTelefona { get; set; }
        [ForeignKey("Lokacija")]
        public int lokacija { get; set; }
        public string nazivRadnje { get; set; }
        public int tipDjelatnika { get; set; }
        public int djelatnost { get; set; }

        public bool banovan { get; set; }
        [ForeignKey("Korisnik")]
        public int IDAdministratora { get; set; }
    }
}
