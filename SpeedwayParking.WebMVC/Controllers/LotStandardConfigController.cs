using Microsoft.AspNetCore.Mvc;
using SpeedwayParking.Contracts;
using SpeedwayParking.Models.Lot;
using SpeedwayParking.Models.LotStandardConfig;
using SpeedwayParking.Services;

namespace SpeedwayParking.WebMVC.Controllers
{
    public class LotStandardConfigController : Controller
    {
        private readonly ILotStandardConfigService _lotStandardConfigService;

        public LotStandardConfigController(ILotStandardConfigService lotStandardConfigService)
        {
            _lotStandardConfigService = lotStandardConfigService;
        }

        public IActionResult Index()
        {
            var allLotStandardConfigs = _lotStandardConfigService.GetAllLotStandardConfigs();
            return View(allLotStandardConfigs);
        }

        public IActionResult Create()
        {
            var lots = _lotStandardConfigService.GetAllLotStandardConfigs();
            return View(lots);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(LotStandardConfigCreate model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            _lotStandardConfigService.CreateLotStandardConfig(model);
            return RedirectToAction("Index");
        }

        public IActionResult Details(int id)
        {
            var lotStandardConfig = _lotStandardConfigService.GetLotStandardConfigById(id);
            return View(lotStandardConfig);
        }

        public IActionResult Edit(int id)
        {
            var service = _lotStandardConfigService;
            var detail = service.GetLotStandardConfigById(id);
            var model =
                new LotStandardConfigEdit
                {
                    Id = detail.Id,
                    NumberOfAutoSpaces = detail.NumberOfAutoSpaces,
                    NumberOfRvSpaces = detail.NumberOfRvSpaces,
                    NumberOfMotorcycleSpaces = detail.NumberOfMotorcycleSpaces,
                    NumberOfAdaSpaces = detail.NumberOfAdaSpaces
                };
            return View(model);
        }

        [HttpPut]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, LotStandardConfigEdit model)
        {
            if (!ModelState.IsValid) return View(model);

            if (model.Id != id)
            {
                ModelState.AddModelError("", "LotStandardConfig Id does not match");
                return View(model);
            }

            var service = _lotStandardConfigService;
            if (service.EditLotStandardConfig(model))
            {
                TempData["SaveResult"] = "The LotStandardConfig has been updated.";
                return RedirectToAction("Index");
            }

            ModelState.AddModelError("", "The LotStandardConfig could not be updated.");
            return View(model);
        }

        [ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            var model = _lotStandardConfigService.GetLotStandardConfigById(id);
            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeletePost(int id)
        {
            var service = _lotStandardConfigService;

            service.DeleteLotStandardConfig(id);

            TempData["SaveResult"] = "The LotStandardConfig has been deleted.";

            return RedirectToAction("Index");
        }

    }
}
