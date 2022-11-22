using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Models.EventLot
{
    public class EventLotEdit
    {
        public bool DailyParking { get; set; }
        public bool OvernightParking { get; set; }
        public bool Tailgating { get; set; }
        public bool Electricity30a { get; set; }
        public bool Electricity50a { get; set; }
        public bool Shower { get; set; }
        public int NumberOfAutoSpaces { get; set; }
        public int NumberOfRvSpaces { get; set; }
        public int NumberOfMotorcycleSpaces { get; set; }
        public int NumberOfAdaSpaces { get; set; }
    }
}
