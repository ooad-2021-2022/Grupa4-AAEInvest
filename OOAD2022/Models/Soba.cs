using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOAD2022.Models
{
    public class Soba
    {
        [Key]
        public int Id { get; set; }
        public int Kvadratura { get; set; }
        public int BrojKreveta { get; set; }
        public string NazivSmjestaja { get; set; }
        public int Cijena { get; set; }
        [ForeignKey("Rezervacija")]
        public int RezervacijaId { get; set; }
        [ForeignKey("Smjestaj")]
        public int SmjestajId { get; set; }

        Soba() { }
    }
}
