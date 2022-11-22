using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using SpeedwayParking.Contracts;
using SpeedwayParking.Models.Event;
using SpeedwayParking.Models.Lot;
using SpeedwayParking.Models.LotStandardConfig;
using SpeedwayParking.Services;

namespace SpeedwayParking.WebMVC.Controllers
{
    public class EventController : Controller
    {
        //private readonly ApplicationDbContext _context;
        private readonly IEventService _eventService;
        private readonly ILotStandardConfigService _lotStandardConfigService;
        private readonly IEventLotService _eventLotService;

        public EventController(IEventService eventService, ILotStandardConfigService lotStandardConfigService, IEventLotService eventLotService)
        {
            _eventService = eventService;
            _lotStandardConfigService = lotStandardConfigService;
            _eventLotService = eventLotService;
        }


        public async Task<IActionResult> Index()
        {
            return View(_eventService.GetAllEvents());
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("Name,Location,DateStart,DateEnd")] EventCreate model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var intContainer = _eventService.CreateEventAsync(model);
        //        if (intContainer == null)
        //        {
        //            return View(model);
        //        }
        //        var lotInfo = await _lotStandardConfigService.GetAllLotStandardConfigsAsync();
        //        foreach (var lot in lotInfo)
        //        {

        //        }

        //        //_eventService.Events.Add(new Event
        //        //{
        //        //    Name = model.Name,
        //        //    Location = model.Location,
        //        //    DateStart = model.DateStart,
        //        //    DateEnd = model.DateEnd
        //        //});
        //        //await _eventService.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(model);
        //}

        public async Task<IActionResult> Details(int id)
        {
            var model = _eventService.GetEventByIdAsync(id);
            return View(model);
        }

        // NULL REFERENCE?
        public async Task<IActionResult> Edit(int id)
        {
            var service = _eventService;
            var detail = await service.GetEventByIdAsync(id);
            var model =
                new EventEdit
                {
                    Id = detail.Id,
                    Name = detail.Name,
                    Location = detail.Location,
                    DateStart = detail.DateStart,
                    DateEnd = detail.DateEnd
                };
            return View(model);
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EventEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if(model.Id != id)
            {
                ModelState.AddModelError("", "Event Id does not match");
                return View(model);
            }

            var service = _eventService;
            if (await service.EditEventAsync(model))
            {
                TempData["SaveResult"] = "The event has been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The event could not be updated.");
            return View(model);
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("Name,Location,DateStart,DateEnd")] EventEdit model)
        //{
        //    var eventitem = await _context.Events.FindAsync(id);
        //    if (eventitem == null)
        //    {
        //        return NotFound();
        //    }
        //    if (ModelState.IsValid)
        //    {
        //        eventitem.Name = model.Name;
        //        eventitem.Location = model.Location;
        //        eventitem.DateStart = model.DateStart;
        //        eventitem.DateEnd = model.DateEnd;
        //        try
        //        {
        //            _context.Update(eventitem);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch
        //        {
        //            //if (eventitem.Id != id))
        //            //{
        //            //    return NotFound();
        //            //}
        //            //else
        //            //{
        //            //    throw;
        //            //}
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(eventitem);
        //}
    }
}
