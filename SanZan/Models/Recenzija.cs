using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Recenzija
    {
        [Key]
        public int IDRecenzije { get; set; }
        [ForeignKey("Korisnik")]
        public int IDRecenzenta { get; set; }
        [ForeignKey("Korisnik")]
        public int IDjelatnika { get; set; }
        public DateTime vrijeme { get; set; }
        public int ocjena { get; set; }
        public string komentar { get; set; }
    }
}
