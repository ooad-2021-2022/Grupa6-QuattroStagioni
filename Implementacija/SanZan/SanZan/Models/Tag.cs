using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SanZan.Models
{
    public class Tag
    {
        [Key]
        public int IDTaga { get; set; }
        [Required]
        public string Naziv { get; set; }
        [EnumDataType(typeof(Djelatnost))]
        public Djelatnost Djelatnost { get; set; }
    }
}
