using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOAD2022.Models
{
    public class Slike
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }
        [ForeignKey("Soba")]
        public int SobaId { get; set; }
        [ForeignKey("Smjestaj")]
        public int SmjestajId { get; set; }

        [ForeignKey("Rezervacija")]
        public int RezervacijaId { get; set; }

        Slike() { }
    }
}
