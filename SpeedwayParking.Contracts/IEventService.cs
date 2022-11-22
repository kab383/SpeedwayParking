using SpeedwayParking.Models.Event;
using SpeedwayParking.Models.Lot;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SpeedwayParking.Contracts
{
    public interface IEventService
    {
        IEnumerable<EventIndex> GetAllEvents();
        int? CreateEvent(EventCreate model);
        EventDetails GetEventById(int id);
        bool EditEvent(EventEdit model);
        bool DeleteEvent(int id);
    }
}
