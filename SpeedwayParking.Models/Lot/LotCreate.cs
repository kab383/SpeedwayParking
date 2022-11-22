using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Models.Lot
{
    public class LotCreate
    {
        [Display(Name = "Lot")]
        [Required(ErrorMessage = "Lot name is required.")]
        public string Name { get; set; }
        [Display(Name = "Entrance")]
        [Required(ErrorMessage = "Nearest entrance is required.")]
        public string Entrance { get; set; }
        [Display(Name = "Select a ground surface type for the lot.")]
        [Required(ErrorMessage = "Nearest entrance is required.")]
        public string Surface { get; set; }
    }
}
