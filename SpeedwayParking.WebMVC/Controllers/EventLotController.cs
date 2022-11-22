using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpeedwayParking.Contracts;
using SpeedwayParking.Data;
using SpeedwayParking.Models.Event;
using SpeedwayParking.Models.EventLot;

namespace SpeedwayParking.WebMVC.Controllers
{
    public class EventLotController : Controller
    {

            //private readonly ApplicationDbContext _context;
            private readonly IEventLotService _eventLotService;

            public EventLotController(IEventLotService eventLotService)
            {
                _eventLotService = eventLotService;
            }


            public async Task<IActionResult> Index()
            {
                return View(_eventLotService.GetAllEventLotsAsync());
            }

            public async Task<IActionResult> Create()
            {
            return View();
            }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("DailyParking,OvernightParking,Tailgating,Electricity30a,Electricity50a,Shower,NumberOfAutoSpaces,NumberOfRvSpaces,NumberOfMotorcycleSpaces,NumberOfAdaSpaces")] EventLotCreate model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _eventLotService.EventLots.Add(new EventLot
        //        {
        //            DailyParking = model.DailyParking,
        //            OvernightParking = model.OvernightParking,
        //            Tailgating = model.Tailgating,
        //            Electricity30a = model.Electricity30a,
        //            Electricity50a = model.Electricity50a,
        //            Shower = model.Shower,
        //            NumberOfAutoSpaces = model.NumberOfAutoSpaces,
        //            NumberOfRvSpaces = model.NumberOfRvSpaces,
        //            NumberOfMotorcycleSpaces = model.NumberOfMotorcycleSpaces,
        //            NumberOfAdaSpaces = model.NumberOfAdaSpaces
        //        });
        //        await _eventLotService.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(model);
        //}
    }
}
