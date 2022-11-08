using Microsoft.AspNetCore.Mvc;
using SpeedwayParking.Models.Event;

namespace SpeedwayParking.WebMVC.Controllers
{
    public class EventController : Controller
    {
        public IActionResult Index()
        {
            var model = new EventListItem[0];
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create (EventCreate model)
        {
            if (ModelState.IsValid)
            {

            }
            return View(model);
        }
    }
}
