using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class ZahtjevTagovi
    {
        [Key]
        public int IDZahtjevTagovi { get; set; }
        [ForeignKey("Zahtjev")]
        public int IDZahtjev { get; set; }
        [ForeignKey("Tag")]
        public int IDTaga { get; set; }
    }
}
