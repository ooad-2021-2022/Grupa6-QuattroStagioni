using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class GlobalnaStatistika
    {
        public int brojKorisnika { get; set; }
        public int brojOglasa { get; set; }
        public int brojBanovanihKorisnika { get; set; }
        public int brojUspjesnihSaradnji { get; set; }
    }
}
