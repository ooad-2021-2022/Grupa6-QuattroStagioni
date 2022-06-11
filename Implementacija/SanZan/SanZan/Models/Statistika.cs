using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Statistika
    {
        [Key]
        public int IDDjelatnika { get; set; }
        public int brojUspjesnihSaradnji { get; set; }
        public int brojPosjeta { get; set; }
        public int brojPrijava { get; set; }
        public int brojUcesca { get; set; }
    }
}
