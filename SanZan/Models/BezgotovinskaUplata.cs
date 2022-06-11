using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace SanZan.Models
{
    public class BezgotovinskaUplata
    {
        [Key]
        public int IDUplate { get; set; }
        [ForeignKey("Kartica")]
        public int IDKarticeKlijenta { get; set; }
        [ForeignKey("Kartica")]
        public int IDKarticeDjelatnika { get; set; }
        public double iznosUplate { get; set; }
    }
}
