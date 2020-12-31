using Microsoft.AspNetCore.Mvc;
using OrchardSkills.RaspberryPi.LedOnOff;
using OrchardSkills.RaspberryPi.LedOnOff.Models;
using OrchardSkills.RaspberryPi.LedOnOff.Devices;
using System.Diagnostics;

namespace OrchardSkills.RaspberryPi.LedOnOff.Controllers
{
    public class HomeController : Controller
    {
        private readonly LedDevice _ledDevice;
        public HomeController(LedDevice ledDevice)
        {
            _ledDevice = ledDevice;
        }

        public IActionResult Index()
        {
            ViewBag.LedSupported = _ledDevice.IsLedSupported ? "Yes" : "No";
            ViewBag.LedState = _ledDevice.IsLedOn ? "On" : "Off";
            return View();
        }

        public IActionResult LedOn()
        {
            _ledDevice.LedOn();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult LedOff()
        {
            _ledDevice.LedOff();

            return RedirectToAction(nameof(Index));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
