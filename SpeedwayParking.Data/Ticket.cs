using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Data
{
    public class Ticket
    {
        [Key]
        public int Id { get; set; }
        public Guid UserId { get; set; }
        [Required]
        public bool Purchased { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Lot { get; set; }
        [Required]
        public string Event { get; set; }
        [Required]
        public DateTime DateOfSale { get; set; }
        [Required]
        public int LotId { get; set; }
        [Required]
        public int EventId { get; set; }
    }
}
