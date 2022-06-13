using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SanZan.Models
{
    public enum Djelatnost
    {
        [Display(Name = "Automehaničar")]
        Automehanicar,
        Bravar,
        [Display(Name = "Električar")]
        Elektricar,
        [Display(Name = "Keramičar")]
        Keramicar,
        [Display(Name = "Krojač")]
        Krojac,
        Limar,
        Moler,
        Monter,
        [Display(Name = "Obućar")]
        Obucar,
        Stolar,
        Urar,
        Vodoinstalater,
        Zidar
    }
}
