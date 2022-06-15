using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOAD2022.Models
{
    public class ValidateDate : ValidationAttribute
    {
        protected override ValidationResult IsValid
        (object date, ValidationContext validationContext)
        {
            return ((DateTime)date >= DateTime.Now)
            ? ValidationResult.Success
            : new ValidationResult("Validan je datum od datuma danasnjeg dana");
        }
    }
    public class Rezervacija
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Sifra { get; set; }
        [Display(Name = "Datum dolaska")]
        [ValidateDate]
        [DataType(DataType.Date)]
        public DateTime DatumDolaska { get; set; }
        [Display(Name = "Datum odlaska")]
        [ValidateDate]
        [DataType(DataType.Date)]
        public DateTime DatumOdlaska { get; set; }
        [Required]
        public int Cijena { get; set; }

        [ForeignKey("Uplata")]
        [Required]
        public int UplataId { get; set; }
        public Uplata Uplata { get; set; }


        [ForeignKey("Korisnik")]
        [Required]
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }

        [ForeignKey("Smjestaj")]
        [Required]
        public int SmjestajId { get; set; }
        public Smjestaj Smjestaj { get; set; }

       public Rezervacija() { }
    }
}
