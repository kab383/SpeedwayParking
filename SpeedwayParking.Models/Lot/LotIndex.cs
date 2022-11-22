using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Models.Lot
{
    public class LotIndex
    {
        public int Id { get; set; }
        [Display(Name = "Lot Name")]
        public string Name { get; set; }
        [Display(Name = "Nearest Lot Entrance")]
        public string Entrance { get; set; }
        [Display(Name = "Ground Surface")]
        public string Surface { get; set; }
    }
}
