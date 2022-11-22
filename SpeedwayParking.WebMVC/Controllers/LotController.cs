using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SpeedwayParking.Contracts;
using SpeedwayParking.Models.Event;
using SpeedwayParking.Models.Lot;
using SpeedwayParking.Services;

namespace SpeedwayParking.WebMVC.Controllers
{
    public class LotController : Controller
    {
        private readonly ILotService _lotService;

        public LotController(ILotService lotService)
        {
            _lotService = lotService;
        }

        public async Task<IActionResult> Index()
        {
            return View(_lotService.GetAllLots());
        }

        public async Task<IActionResult> Create()
        {
            var lots = await _lotService.GetAllLots();
            return View(lots);
        }

        //public async Task<IActionResult> EditLot(int id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }
        //    var eventItem = await _lotService
        //        .Events
        //        .Select(e => new EventEdit
        //        {
        //            Id = e.Id,
        //            Name = e.Name,
        //            Location = e.Location,
        //            DateStart = e.DateStart,
        //            DateEnd = e.DateEnd
        //        })
        //        .FirstOrDefaultAsync(e => e.Id == id);
        //    if (eventItem == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(eventItem);
        //}
        
    }
}
