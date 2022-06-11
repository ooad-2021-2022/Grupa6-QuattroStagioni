using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class DjelatnikTagovi
    {
        [Key]
        public int IDDjelatnikTagovi { get; set; }
        [ForeignKey("Korisnik")]
        public int IDDjelatnika { get; set; }
        [ForeignKey("Tag")]
        public int IDTaga { get; set; }
}
}
