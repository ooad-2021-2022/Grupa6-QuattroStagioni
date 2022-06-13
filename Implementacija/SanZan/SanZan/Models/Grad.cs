using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SanZan.Models
{
    public enum Grad
    {
        [Display(Name = "Banja Luka")]
        BanjaLuka,
        [Display(Name = "Bihać")]
        Bihac,
        Bijeljina,
        [Display(Name = "Bosanska Krupa")]
        BosanskaKrupa,
        Cazin,
        [Display(Name = "Čapljina")]
        Capljina,
        Derventa,
        Doboj,
        [Display(Name = "Goražde")]
        Gorazde,
        [Display(Name = "Gračanica")]
        Gracanica,
        [Display(Name = "Gradačac")]
        Gradacac,
        [Display(Name = "Gradiška")]
        Gradiska,
        [Display(Name = "Istočno Sarajevo")]
        IstocnoSarajevo,
        Konjic,
        Livno,
        Lukavac,
        [Display(Name = "Ljubuški")]
        Ljubuski,
        Mostar,
        [Display(Name = "Orašje")]
        Orasje,
        Prijedor,
        Sarajevo,
        Srebrenik,
        Stolac,
        [Display(Name = "Široki Brijeg")]
        SirokiBrijeg,
        Trebinje,
        Tuzla,
        Visoko,
        [Display(Name = "Zavidovići")]
        Zavidovici,
        Zenica,
        Zvornik,
        [Display(Name = "Živinice")]
        Zivinice
    }
}
