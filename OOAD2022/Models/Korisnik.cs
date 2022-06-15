using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OOAD2022.Models
{
    public class ValidateDate2 : ValidationAttribute
    {
        protected override ValidationResult IsValid
        (object date, ValidationContext validationContext)
        {
            return ((DateTime)date < DateTime.Now)
            ? ValidationResult.Success
            : new ValidationResult("Validan je datum prije danasnjeg datuma");
        }
    }
    public class Korisnik
    {
        [Key]
        public int KorisnikId { get; set; }
        [DisplayName("Ime i prezime")]
        [Required]
        public string KorisnikImeIPrezime { get; set; }
        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov|ba)$", ErrorMessage = "Invalid pattern.")]
        public string Email { get; set; }
        [Required]
        public string Lozinka { get; set; }

        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage ="Nevalidna adresa!")]
        public string Adresa { get; set; }
        [ValidateDate2]
        [DataType(DataType.Date)]
        public DateTime Godiste { get; set; }

        public Korisnik() { }
    }
}
