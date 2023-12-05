using AutomativeTaskNotificationFacadeService;
using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using FlexibleAutomationTool.Mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Timers;

namespace FlexibleAutomationTool.Mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ScheduleNotificationFacadeService _facade;

        public HomeController(ILogger<HomeController> logger, ScheduleNotificationFacadeService facade)
        {
            _logger = logger;
            _facade = facade;
        }

        public async Task<IActionResult> Index()
        {
            
            //await _facade.TimerTaskAsync2();
            //var books = _books.GetAll();
            return View();
        }

        private void TimerRealisation()
        {
            var _timer = new System.Timers.Timer();
            _timer.Elapsed += async (sender, e) =>
            {
                (async state => await TimerTaskAsync2());
            };
            //_timer.Elapsed += new ElapsedEventHandler(_facade.TimerTaskAsync2());
            _timer.Interval = 10000; // інтервал у мілісекундах (наприклад, 10 секунд)
            _timer.Start();
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