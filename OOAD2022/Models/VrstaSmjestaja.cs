using System.ComponentModel.DataAnnotations;

namespace OOAD2022.Models
{
    public enum VrstaSmjestaja
    {
        [Display(Name = "Hotel")]
        Hotel,
        [Display(Name = "Motel")] 
        Motel,
        [Display(Name = "Hostel")] 
        Hostel,
        [Display(Name = "Apartman")]
        Apartman
    }
}
