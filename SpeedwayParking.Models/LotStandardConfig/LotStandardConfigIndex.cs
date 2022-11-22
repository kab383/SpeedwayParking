using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpeedwayParking.Models.LotStandardConfig
{
    public class LotStandardConfigIndex
    {
        public int Id { get; set; }
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
