using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Models.EventLot
{
    public class EventLotCreate
    {
        public int LotId { get; set; }
        public int EventId { get; set; }
        [Display(Name = "Daily Parking Available")]
        [Required(ErrorMessage = "This field is required.")]
        public bool DailyParking { get; set; }
        [Display(Name = "Overnight Parking Available")]
        [Required(ErrorMessage = "This field is required.")]
        public bool OvernightParking { get; set; }
        [Display(Name = "Tailgating Allowed")]
        [Required(ErrorMessage = "This field is required.")]
        public bool Tailgating { get; set; }
        [Display(Name = "30a Electricity Available")]
        [Required(ErrorMessage = "This field is required.")]
        public bool Electricity30a { get; set; }
        [Display(Name = "50a Electricity Available")]
        [Required(ErrorMessage = "This field is required.")]
        public bool Electricity50a { get; set; }
        [Display(Name = "Showers Available")]
        [Required(ErrorMessage = "This field is required.")]
        public bool Shower { get; set; }
        // The spaces are not required, as there is a lot standard config that will apply if left blank.
        [Display(Name = "Total Number of Auto Spaces")]
        public int NumberOfAutoSpaces { get; set; }
        [Display(Name = "Total Number of RV Spaces")]
        public int NumberOfRvSpaces { get; set; }
        [Display(Name = "Total Number of Motorcycle Spaces")]
        public int NumberOfMotorcycleSpaces { get; set; }
        [Display(Name = "Total Number of ADA Spaces")]
        public int NumberOfAdaSpaces { get; set; }
    }
}
