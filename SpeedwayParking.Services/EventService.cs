using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using SpeedwayParking.Contracts;
using SpeedwayParking.Data;
using SpeedwayParking.Models.Event;
using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedwayParking.Services
{

    public class EventService : IEventService
    {
        private readonly ApplicationDbContext _context;
        public EventService(ApplicationDbContext context)
        {
            _context = context;
        }

        //admin only feature
        public async Task<int?> CreateEventAsync(EventCreate model)
        {
            var eventEntity =
                new Event()
                {
                    Name = model.Name,
                    Location = model.Location,
                    DateStart = model.DateStart,
                    DateEnd = model.DateEnd,
                };
            _context.Events.Add(eventEntity);
            if (_context.SaveChanges() == 1)
            {
                return eventEntity.Id;
            }
            return null;
        }

        public async Task<EventDetails> GetEventByIdAsync(int Id)
        {
            var eventEntity = await _context
                .Events
                .FirstOrDefaultAsync(e => e.Id == Id);

            if (eventEntity == null)
                return null;

            var eventDetails = new EventDetails
            {
                Id = eventEntity.Id,
                Name = eventEntity.Name,
                Location = eventEntity.Location,
                DateStart = eventEntity.DateStart,
                DateEnd = eventEntity.DateEnd
            };
            return eventDetails;
        }

        public IEnumerable<EventIndex> GetAllEvents()
        {
            var eventEntity = _context
                .Events
                .Select(e => new EventIndex
                {
                    Id = e.Id,
                    Name = e.Name,
                    Location = e.Location,
                    DateStart = e.DateStart,
                    DateEnd = e.DateEnd,
                })
                .ToList();
                return eventEntity;
        }

        public async Task<bool> EditEventAsync(EventEdit model)
        {
            var eventEntity = await _context.Events.FindAsync(model.Id);
            if (eventEntity?.Id != model.Id)
                return false;

            eventEntity.Name = model.Name;
            eventEntity.Location = model.Location;
            eventEntity.DateStart = model.DateStart;
            eventEntity.DateEnd = model.DateEnd;

            var eventEdits = await _context.SaveChangesAsync();
            return eventEdits == 1;
        }



    }
}
