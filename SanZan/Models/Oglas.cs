using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Oglas
    {
        [Key, ForeignKey("ModeratorOglasi")]
        public int IDOglasa { get; set; }
        [ForeignKey("Korisnik")]
        public int IDDjelatnika { get; set; }
        public string nazivShopa { get; set; }
        [ForeignKey("Lokacija")]
        public int lokacija { get; set; }
        public double ocjena { get; set; }
        public string opis { get; set; }
        public int status { get; set; }
    }
}
