using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Models.Ticket
{
    public class TicketDetails
    {
        public int Id { get; set; }
        public Guid UserId { get; set; }
        // Default value of booleans are false in C#, so when ticket is created the Purchased bool is already false.
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
        // Bring in event info from Event, also through EventLot
        //public virtual Event EventInfo { get; set; }
    }
}
