using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class InfoPitanje
    {
        [Key]
        public int IDPitanja { get; set; }
        public string pitanje { get; set; }
        public string odgovor { get; set; }
    }
}
