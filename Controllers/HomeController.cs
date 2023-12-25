using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebNet3.Services;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using WebNet3.Models;

namespace WebNet3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IEnumerable<Ada> adas = CSVService.ReadCSV<Ada>("ADA.csv");

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("ADATate")] 
        public IActionResult ADADate()
        {
            return View(adas);
        }

        [Route("CryptoDayInfo/{date}")]
        public IActionResult CryptoDayInfo(string date)
        {
            var ad = adas.FirstOrDefault(a => a.date == date);
            if (ad == null)
            {
                return NotFound();
            }
            return View(ad);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
    }
}
