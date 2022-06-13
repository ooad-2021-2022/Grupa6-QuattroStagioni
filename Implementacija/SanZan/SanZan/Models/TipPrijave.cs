using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SanZan.Models
{
    public enum TipPrijave
    {
        [Display (Name = "Lažni podaci")]
        LazniPodaci,
        [Display(Name = "Narušavanje privatnosti")]
        NarusavanjePrivatnosti,
        [Display(Name = "Neprimjeren sadržaj")]
        NeprimjerenSadrzaj,
        [Display(Name = "Govor mržnje")]
        GovorMrznje
    }
}
