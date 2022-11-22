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
        //[Display(Name = "List of events this lot is used for")]
        //public virtual List<EventLot> EventLots { get; set; }
        //[Display(Name = "Standard lot attributes and available parking spaces:")]
        //public virtual LotStandardConfig LotStandardConfig { get; set; }
    }
}
