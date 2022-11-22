using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Models.Lot
{
    public class LotDelete
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Entrance { get; set; }
        public string Surface { get; set; }
    }
}
