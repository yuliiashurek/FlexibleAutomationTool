using FlexibleAutomationTool.BL.IServices;
using FlexibleAutomationTool.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FlexibleAutomationTool.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ICommand _command;

        public HomeController(ILogger<HomeController> logger, ICommand command)
        {
            _logger = logger;
            _command = command;
        }

        public IActionResult Index()
        {
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