using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOAD2022.Models
{
    public class Recenzija
    {
        [Key]
        public int Id { get; set; }
        public int OcjenaSmjestaja { get; set; }
        public string NazivSmjestaja { get; set; }
        public int OcjenaAplikacije { get; set; }
        [ForeignKey("Soba")]
        public int SobaId { get; set; }
        [ForeignKey("Smjestaj")]
        public int SmjestajId { get; set; }
        [ForeignKey("Rezervacija")]
        public int RezervacijaId { get; set; }

        Recenzija() { }
    }
}
