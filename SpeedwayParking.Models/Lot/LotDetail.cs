using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpeedwayParking.Models.Lot
{
    public class LotDetail
    {
        public int Id { get; set; }
        [Display(Name = "Lot Name")]
        public string Name { get; set; }
        [Display(Name = "Nearest Lot Entrance")]
        public string Entrance { get; set; }
        [Display(Name = "Ground Surface")]
        public string Surface { get; set; }
        [Display(Name = "Standard number of auto spaces for this lot")]
        public int NumberOfAutoSpaces { get; set; }
        [Display(Name = "Standard number of RV spaces for this lot")]
        public int NumberOfRvSpaces { get; set; }
        [Display(Name = "Standard number of Motorcycle spaces for this lot")]
        public int NumberOfMotorcycleSpaces { get; set; }
        [Display(Name = "Standard number of ADA spaces for this lot")]
        public int NumberOfAdaSpaces { get; set; }
    }
}
