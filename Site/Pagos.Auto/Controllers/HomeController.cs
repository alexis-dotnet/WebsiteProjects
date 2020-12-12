using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pagos.Auto.Models;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Schema;
using Pagos.Auto.Data;

namespace Pagos.Auto.Controllers
{
    public class HomeController : Controller
    {
        public class ButtonModel
        {
            public string content { get; set; }
            public string cssClass { get; set; }
        }

        private decimal Total = 120 * 60;
        private readonly ILogger<HomeController> _logger;
        private readonly IMainData _mainData;

        public HomeController(ILogger<HomeController> logger, IMainData mainData)
        {
            _logger = logger;
            _mainData = mainData;
        }

        public async Task<IActionResult> Index()
        {
            var data = await _mainData.GetAllCarPaymentsAsync();
            var totalPayed = data.Sum(x => x.Amount);
            var totalToPay = Total - totalPayed;

            ViewBag.DataSource = data;
            ViewBag.DialogButtonsOk = new ButtonModel() { cssClass = "e-primary", content = "Guardar" };
            ViewBag.DialogButtonsCancel = new ButtonModel() { content = "Cancelar", cssClass = "e-flat" };
            ViewBag.TotalPayed = totalPayed;
            ViewBag.TotalToPay = totalToPay;

            return View();
        }

        public IActionResult Privacy()
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
