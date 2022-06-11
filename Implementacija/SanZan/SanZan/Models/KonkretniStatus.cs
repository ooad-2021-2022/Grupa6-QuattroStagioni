using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SanZan.Models
{
    public class KonkretniStatus
    {
        [Key]
        public int IDStatus { get; set; }
        public Markeri marker { get; set; }
    }
}
