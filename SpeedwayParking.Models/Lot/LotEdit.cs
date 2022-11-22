using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Models.Lot
{
    public class LotEdit
    {
        public int Id { get; set; }
        [Display(Name = "Change Lot Name")]
        public string Name { get; set; }
        [Display(Name = "Change Lot Entrance")]
        public string Entrance { get; set; }
        [Display(Name = "Change Lot Surface")]
        public string Surface { get; set; }
    }
}
