using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOAD2022.Models
{
    public class Smjestaj
    {
        [Key]
        public int SmjestajId { get; set; }
        public string NazivSmjestaja { get; set; }
        public string AdresaSmjestaja { get; set; }
        public string Kontakt { get; set; }
        [EnumDataType(typeof(VrstaSmjestaja))]
        public VrstaSmjestaja VrstaSmjestaja { get; set; }
        [ForeignKey("Slike")]
        public int SlikaId { get; set; }
        public Slike Slike { get; set; }

       public Smjestaj() { }
    }
}
