using Microsoft.AspNetCore.Mvc;
using SpeedwayParking.Contracts;
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

        //public async Task<IActionResult> Index()
        //{
        //    return View(_lotStandardConfigService.GetAll);
        //}

        public async Task<IActionResult> Create()
        {
            return View();
        }

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create(LotStandardConfigCreate model)
        //{

        //}

        //public async Task<IActionResult> Details(int id)
        //{
        //    LotStandardConfigDetails lotStandardConfigDetails = await _lotStandardConfigService.GetLotStandardConfigDetails(id);
        //    if (lotStandardConfigDetails == null) return RedirectToAction(nameof(Index));
        //    return View(lotStandardConfigDetails);
        //}
    }
}
