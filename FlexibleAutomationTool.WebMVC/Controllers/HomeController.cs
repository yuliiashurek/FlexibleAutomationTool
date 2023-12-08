using AutomativeTaskNotificationFacadeService;
using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using FlexibleAutomationTool.WebMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Timers;

namespace FlexibleAutomationTool.WebMVC.Controllers
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

        public IActionResult Index()
        {
            return View();
        }
    }
}