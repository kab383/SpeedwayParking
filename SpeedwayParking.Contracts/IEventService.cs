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
        Task<int?> CreateEventAsync(EventCreate model);
        Task<EventDetails> GetEventByIdAsync(int id);
        Task<bool> EditEventAsync(EventEdit model);
        //Task<bool> DeleteEventAsync(int id);
    }
}
