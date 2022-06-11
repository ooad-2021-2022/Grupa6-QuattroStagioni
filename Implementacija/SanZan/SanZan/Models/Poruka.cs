﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Poruka
    {
        [Key]
        public int IDPoruke { get; set; }
        [ForeignKey("Korisnik")]
        public int IDPrimaoca { get; set; }
        [ForeignKey("Korisnik")]
        public int IDPosiljaoca { get; set; }
        public DateTime vrijeme { get; set; }
        public string sadrzaj { get; set; }
    }
}