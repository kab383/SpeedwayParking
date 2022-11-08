using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Data
{
    public class LotStandardConfig
    {
        [Key, ForeignKey(nameof(Lot))]
        public int Id { get; set; }
        // When creating models set a range for the number of spaces.
        public int NumberOfAutoSpaces { get; set; }
        public int NumberOfRvSpaces { get; set; }
        public int NumberOfMotorcycleSpaces { get; set; }
        public int NumberOfAdaSpaces { get; set; }
    }
}
