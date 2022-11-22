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
        public int? CreateEvent(EventCreate model)
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

        public EventDetails GetEventById(int id)
        {
            var eventEntity = _context
                .Events
                .Single(e => e.Id == id);

            return
                new EventDetails
            {
                Id = eventEntity.Id,
                Name = eventEntity.Name,
                Location = eventEntity.Location,
                DateStart = eventEntity.DateStart,
                DateEnd = eventEntity.DateEnd
            };
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

        public bool EditEvent(EventEdit model)
        {
            var eventEntity = _context.Events.Single(e => e.Id == model.Id);

            eventEntity.Name = model.Name;
            eventEntity.Location = model.Location;
            eventEntity.DateStart = model.DateStart;
            eventEntity.DateEnd = model.DateEnd;

            return _context.SaveChanges() == 1;
        }

        public bool DeleteEvent(int id)
        {
            var deleteEntity = _context.Events.Single(e => e.Id == id);

            _context.Events.Remove(deleteEntity);

            return _context.SaveChanges() == 1;
        }
    }
}
