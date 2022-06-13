using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SanZan.Models
{
    public enum Markeri
    {
        [Display(Name = "Obični")]
        Obicni,
        Hitno,
        [Display(Name = "Preporučeni")]
        Preporuceni
    }
}
