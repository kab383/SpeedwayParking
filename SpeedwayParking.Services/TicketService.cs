using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Services
{
    public class TicketService
    {
        private readonly Guid _userId;

        public TicketService(Guid userId)
        {
            _userId = userId;
        }

    }
}
