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


        public IActionResult Index()
        {
            var events = _eventService.GetAllEvents();
            return View(events);
        }

        public IActionResult Create()
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

        public IActionResult Details(int id)
        {
            var model = _eventService.GetEventById(id);
            return View(model);
        }

        // NULL REFERENCE?
        public IActionResult Edit(int id)
        {
            var service = _eventService;
            var detail = service.GetEventById(id);
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
        public IActionResult Edit(int id, EventEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if(model.Id != id)
            {
                ModelState.AddModelError("", "Event Id does not match");
                return View(model);
            }

            var service = _eventService;
            if (service.EditEvent(model))
            {
                TempData["SaveResult"] = "The event has been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The event could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            var model = _eventService.GetEventById(id);
            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = _eventService;

            service.DeleteEvent(id);

            TempData["SaveResult"] = "The event has been deleted."; 

            return RedirectToAction("Index");
        }
    }
}
