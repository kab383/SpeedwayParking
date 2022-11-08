using System;
using Xunit;
using Xunit.Sdk;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Models.Event
{
    public class EventCreate
    {
        [Display(Name = "Event")]
        [Required(ErrorMessage = "Event name is required.")]
        public string Name { get; set; }
        [Display(Name = "Location")]
        [Required(ErrorMessage = "Event location is required.")]
        [RegularExpression("^[A-Za-z0-9 ]*$", ErrorMessage = "Please do not use special characters.")]
        public string Location { get; set; }
        [Display(Name = "Start Date")]
        [Required(ErrorMessage = "Event start date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy")]
        public DateTime DateStart { get; set; }
        [Display(Name = "End Date")]
        [Required(ErrorMessage = "Event end date is required.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy")]
        public DateTime DateEnd { get; set; }
    }
}
