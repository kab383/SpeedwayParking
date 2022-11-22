using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Models.Ticket
{
    internal class TicketCreate
    {
        [Display(Name = "Event" )]
        [Required]
        public string Event { get; set; }
        [Required]
        public string Lot { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public DateTimeOffset DateOfSale { get; set; }

    }
}
