using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SpeedwayParking.Models.Event
{
    public class EventIndex
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Track")]
        public string Location { get; set; }
        [Display(Name = "Event Start")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:d")]
        public DateTime DateStart { get; set; }
        [Display(Name = "Event End")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:d")]
        public DateTime DateEnd { get; set; }
    }
}
