using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOAD2022.Models
{
    public class Rezervacija
    {
        [Key]
        public int Id { get; set; }
        public int Sifra { get; set; }
        [Display(Name = "Datum dolaska")]
        public DateTime DatumDolaska { get; set; }
        [Display(Name = "Datum odlaska")]
        public DateTime DatumOdlaska { get; set; }
        public int Cijena { get; set; }

        [ForeignKey("Uplata")]
        public int UplataId { get; set; }
        public Uplata Uplata { get; set; }


        [ForeignKey("Korisnik")]

        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }

        [ForeignKey("Smjestaj")]
        public int SmjestajId { get; set; }
        public Smjestaj Smjestaj { get; set; }

       public Rezervacija() { }
    }
}
