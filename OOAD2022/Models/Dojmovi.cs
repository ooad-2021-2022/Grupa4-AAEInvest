using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOAD2022.Models
{
    public class Dojmovi
    {
        [Key]
        public int Id { get; set; }
        public string Opis { get; set; }
        [ForeignKey("Recenzija")]
        public int RecenzijaId { get; set; }

       public Dojmovi() { }
    }
}
