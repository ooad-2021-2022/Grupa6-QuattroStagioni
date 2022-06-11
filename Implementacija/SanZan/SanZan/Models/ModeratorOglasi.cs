using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class ModeratorOglasi
    {
        [Key, Column(Order = 1), ForeignKey("Korisnik")]
        public int IDModeratora { get; set; }
        [Key, Column(Order = 2), ForeignKey("Oglas")]
        public int IDOglasa { get; set; }
    }
}
