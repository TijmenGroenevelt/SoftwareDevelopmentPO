using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using GaiaZOO.Models;

namespace GaiaZOO.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("species")]

        public IActionResult Species()
        {
            return View();
        }

        [Route("information")]
        public IActionResult Information()
        {
            return View();
        }

        [Route("tickets")]
        public IActionResult Tickets()
        {
            return View();
        }

        [Route("contact")]

        public IActionResult Contact()
        {
            return View();
        }

        [Route("tickets/1-persoons-ticket")]
        public IActionResult Tickets1persoon()
        {
            return View();
        }

        [Route("tickets/familie-dagkaart")]

        public IActionResult Ticketsfamiliedagkaart()
        {
            return View();
        }

        [Route("tickets/grotere-groepen")]

        public IActionResult Ticketsgroteregroepen()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}