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
   
        [ForeignKey("Dojmovi")]
        public int DojamId { get; set; }
        public Dojmovi Dojmovi { get; set; }

        public Recenzija() { }
    }
}
