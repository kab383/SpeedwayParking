using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Data
{
    public class Lot
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Entrance { get; set; }
        [Required]
        public string Surface { get; set; }
        public virtual List<EventLot> EventLotInfo { get; set; } = new List<EventLot>();
        public virtual List<LotStandardConfig> LotStandardConfiguration { get; set; } = new List<LotStandardConfig>();
    }
}
