using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Pagos.Auto.Models;
using System.Diagnostics;
using System.Threading.Tasks;
using Pagos.Auto.Data;

namespace Pagos.Auto.Controllers
{
    public class HomeController : Controller
    {
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
            ViewBag.DataSource = data;
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
