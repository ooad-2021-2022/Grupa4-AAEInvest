using System.ComponentModel.DataAnnotations;

namespace OOAD2022.Models
{
    public class Uplata
    {
        [Key]
        public int Id { get; set; }
        public int UkupnaCijena { get; set; }
        public int Popust { get; set; }
        public int NacinPlacanjaId { get; set; }

        public Uplata() { }
    }
}
