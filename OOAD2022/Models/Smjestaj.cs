﻿using System.ComponentModel.DataAnnotations;

namespace OOAD2022.Models
{
    public class Smjestaj
    {
        [Key]
        public int SmjestajId { get; set; }
        public string NazivSmjestaja { get; set; }
        public string AdresaSmjestaja { get; set; }
        public string Kontakt { get; set; }
        [EnumDataType(typeof(VrstaSmjestaja))]
        public VrstaSmjestaja VrstaSmjestaja { get; set; }

       public Smjestaj() { }
    }
}
