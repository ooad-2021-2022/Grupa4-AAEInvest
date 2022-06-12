﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOAD2022.Models
{
    public class Rezervacija
    {
        [Key]
        public int Id { get; set; }
        public int Sifra { get; set; }
        public DateTime DatumDolaska { get; set; }
        public DateTime DatumOdlaska { get; set; }
        [ForeignKey("Uplata")]
        public int UplataId { get; set; }
        public int Cijena { get; set; }
        [ForeignKey("Recenzija")]
        public int Recenzija { get; set; }
        [ForeignKey("Korisnik")]

        public int KorisnikId { get; set; }

        [ForeignKey("Smjestaj")]
        public int SmjestajId { get; set; }


        Rezervacija() { }
    }
}
