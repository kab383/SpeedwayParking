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
        private readonly ILotStandardConfigService _lotStandardConfigService;

        public LotController(ILotService lotService, ILotStandardConfigService lotStandardConfigService)
        {
            _lotService = lotService;
            _lotStandardConfigService = lotStandardConfigService;
        }

        public IActionResult Index()
        {
            var lots = _lotService.GetAllLots();
            return View(lots);
        }

        public async Task<IActionResult> Create()
        {
            var lots = _lotService.GetAllLots();
            return View(lots);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LotCreate model)
        {
            if(!ModelState.IsValid)
            {
                return View(model);
            }

            _lotService.CreateLot(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var lot = _lotService.GetLotById(id);
            return View(lot);
        }

        public IActionResult Edit(int id)
        {
            var service = _lotService;
            var detail = service.GetLotById(id);
            var model =
                new LotEdit
                {
                    Id = detail.Id,
                    Name = detail.Name,
                    Entrance = detail.Entrance,
                    Surface = detail.Surface,
                };
            return View(model);
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, LotEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.Id != id)
            {
                ModelState.AddModelError("", "Lot Id does not match");
                return View(model);
            }

            var service = _lotService;
            if (service.EditLot(model))
            {
                TempData["SaveResult"] = "The lot has been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The lot could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            var model = _lotService.GetLotById(id);
            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = _lotService;

            service.DeleteLot(id);

            TempData["SaveResult"] = "The lot has been deleted.";

            return RedirectToAction("Index");
        }

    }
}
