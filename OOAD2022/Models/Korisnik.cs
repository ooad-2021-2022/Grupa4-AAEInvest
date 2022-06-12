using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace OOAD2022.Models
{
    public class Korisnik
    {
        [Key]
        public int KorisnikId { get; set; }
        [DisplayName("Ime i prezime")]
        public string KorisnikImeIPrezime { get; set; }
        [Required]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.(com|net|org|gov|ba)$", ErrorMessage = "Invalid pattern.")]
        public string Email { get; set; }
        [Required]
        public string Lozinka { get; set; }

        [Required]
        [StringLength(maximumLength: 50, MinimumLength = 3, ErrorMessage ="Nevalidna adresa!")]
        public string Adresa { get; set; }
        public DateTime Godiste { get; set; }

        public Korisnik() { }
    }
}
