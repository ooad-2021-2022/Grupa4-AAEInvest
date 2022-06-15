using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OOAD2022.Models
{
    public class Smjestaj
    {
        [Key]
        [Display (Name ="ID smještaja")]
        public int SmjestajId { get; set; }
        [Display(Name = "Naziv smještaja")]
        public string NazivSmjestaja { get; set; }
        [Display(Name = "Adresa smještaja")]
        public string AdresaSmjestaja { get; set; }
        public string Kontakt { get; set; }
        [EnumDataType(typeof(VrstaSmjestaja))]
        [Display(Name = "Vrsta smještaja")]
        public VrstaSmjestaja VrstaSmjestaja { get; set; }
        [ForeignKey("Slike")]
        [Display(Name = "ID slike")]
        public int SlikaId { get; set; }
        public Slike Slike { get; set; }

       public Smjestaj() { }
    }
}
