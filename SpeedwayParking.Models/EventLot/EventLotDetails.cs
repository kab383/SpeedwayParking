using SpeedwayParking.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Models.EventLot
{
    public class EventLotDetails
    {
        public int LotId { get; set; }
        //public virtual Lot Lot { get; set; }
        public int EventId { get; set; }
        //public virtual Event Event { get; set; }

        [Required]
        public bool DailyParking { get; set; }
        [Required]
        public bool OvernightParking { get; set; }
        [Required]
        public bool Tailgating { get; set; }
        [Required]
        public bool Electricity30a { get; set; }
        [Required]
        public bool Electricity50a { get; set; }
        [Required]
        public bool Shower { get; set; }
        public int NumberOfAutoSpaces { get; set; }
        public int NumberOfRvSpaces { get; set; }
        public int NumberOfMotorcycleSpaces { get; set; }
        public int NumberOfAdaSpaces { get; set; }
    }
}
