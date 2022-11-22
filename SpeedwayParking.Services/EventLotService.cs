using Microsoft.EntityFrameworkCore;
using SpeedwayParking.Contracts;
using SpeedwayParking.Data;
using SpeedwayParking.Models.Event;
using SpeedwayParking.Models.EventLot;
using SpeedwayParking.Models.Lot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Services
{
    public class EventLotService : IEventLotService
    {
        private readonly ApplicationDbContext _context;
        public EventLotService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<bool> CreateEventLotAsync(EventLotCreate model)
        {
            // ASK MARTY ABOUT THIS ==> .WHERE'S WITH ID's. Doesn't belong in GetAll, but in create???
            //.Where(e => e.LotId == lotId)
            //.Where(e => e.EventId == eventId)
            var eventLotEntity =
                new EventLot() 
                {
                    LotId = model.LotId,
                    EventId = model.EventId,
                    DailyParking = model.DailyParking,
                    OvernightParking = model.OvernightParking,
                    Tailgating = model.Tailgating,
                    Electricity30a = model.Electricity30a,
                    Electricity50a = model.Electricity50a,
                    Shower = model.Shower,
                    NumberOfAutoSpaces = model.NumberOfAutoSpaces,
                    NumberOfRvSpaces = model.NumberOfRvSpaces,
                    NumberOfMotorcycleSpaces = model.NumberOfMotorcycleSpaces,
                    NumberOfAdaSpaces = model.NumberOfAdaSpaces
                };
            _context.EventLots.Add(eventLotEntity);
            return await _context.SaveChangesAsync() == 1;
            //{
            //    return eventLotEntity.Id;
            //}
            //return null;
        }

        public async Task<List<EventLotIndex>> GetAllEventLotsAsync()
        {
            var eventLotEntity = _context
                .EventLots
                .Select(e => new EventLotIndex
                {
                    LotId = e.LotId,
                    EventId = e.EventId,
                    DailyParking = e.DailyParking,
                    OvernightParking = e.OvernightParking,
                    Tailgating = e.Tailgating,
                    Electricity30a = e.Electricity30a,
                    Electricity50a = e.Electricity50a,
                    Shower = e.Shower,
                    NumberOfAutoSpaces = e.NumberOfAutoSpaces,
                    NumberOfRvSpaces = e.NumberOfRvSpaces,
                    NumberOfMotorcycleSpaces = e.NumberOfMotorcycleSpaces,
                    NumberOfAdaSpaces = e.NumberOfAdaSpaces
                });
                return await eventLotEntity.ToListAsync();
        }

        // ASK MARTY
        //public async Task<EventLotDetails> GetEventByIdAsync(int Id, int Id)
        //{
        //    var eventLotEntity = await _context
        //        .EventLots
        //        .FirstOrDefaultAsync(l => l.LotId == Id && r => r.EventId);
        //    if (eventLotEntity == null)
        //        return null;
        //    var eventLotDetails = new EventLotDetails
        //    {
        //        LotId = e.LotId,
        //        EventId = e.EventId,
        //        DailyParking = e.DailyParking,
        //        OvernightParking = e.OvernightParking,
        //        Tailgating = e.Tailgating,
        //        Electricity30a = e.Electricity30a,
        //        Electricity50a = e.Electricity50a,
        //        Shower = e.Shower,
        //        NumberOfAutoSpaces = e.NumberOfAutoSpaces,
        //        NumberOfRvSpaces = e.NumberOfRvSpaces,
        //        NumberOfMotorcycleSpaces = e.NumberOfMotorcycleSpaces,
        //        NumberOfAdaSpaces = e.NumberOfAdaSpaces
        //    };
        //    return eventLotEntity;
        //}

        //public async Task<bool> EditEventAsync(EventEdit model)
        //{

        //}
    }
}
