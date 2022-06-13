using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOAD2022.Models
{
    public class Slike
    {
        [Key]
        public int Id { get; set; }
        public string Url { get; set; }

        public Slike() { }
    }
}
