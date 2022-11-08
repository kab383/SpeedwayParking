using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Data
{
    public class Wishlist
    {
        [Key]
        public Guid UserId { get; set; }
        public virtual ICollection<Ticket> TicketList { get; set; }
    }
}
