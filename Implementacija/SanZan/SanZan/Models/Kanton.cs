using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SanZan.Models
{
    public enum Kanton
    {
        [Display(Name = "Unsko-sanski kanton")]
        UnskoSanski,
        [Display(Name = "Posavski kanton")]
        Posavski,
        [Display(Name = "Tuzlanski kanton")]
        Tuzlanski,
        [Display(Name = "Zeničko-dobojski kanton")]
        ZenickoDobojski,
        [Display(Name = "Bosansko-podrinjski kanton")]
        BosanskoPodrinjski,
        [Display(Name = "Srednjobosanski kanton")]
        Srednjobosanski,
        [Display(Name = "Hercegovačko-neretvanski kanton")]
        HercegovackoNeretvanski,
        [Display(Name = "Zapadnohercegovački kanton")]
        ZapadnoHercegovacki,
        [Display(Name = "Kanton Sarajevo")]
        Sarajevski,
        [Display(Name = "Kanton 10")]
        Kanton10
    }
}
