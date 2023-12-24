using AutomativeTaskNotificationFacadeService;
using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using RepositoryCommandService.Commands;
using RepositoryCommandService.Interface;

namespace FlexibleAutomationTool.WebMVC.Controllers
{
    [Authorize]
    public class UserRuleController : Controller
    {
        private readonly IRepository<Rule> _rules;
        private readonly IMediatorService _mediator;
        private readonly UserManager<IdentityUser> _userManager;
        private readonly ScheduleNotificationFacadeService _facade;

        public UserRuleController(IRepository<Rule> rules, IMediatorService mediator, UserManager<IdentityUser> userManager, ScheduleNotificationFacadeService facade) 
        {
            _mediator = mediator;
            _rules = rules;
            _userManager = userManager;
            _facade = facade;
        } 
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CreateRule()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRule(Rule rule)
        {
            if (rule != null)
            {
                var user = await _userManager.GetUserAsync(User);
                string userId = string.Empty;
                if (user != null)
                {
                    userId = user.Id;
                }
                rule.RuleHistory = new();
                rule.UserId = new Guid(userId);
                _rules.Create(rule);
                _rules.Save();
                return RedirectToAction("RuleList");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult UpdateRule(int id)
        {
            if(id > 0)
            {
                var rule = _rules.Find(id);
                return View(rule);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult UpdateRule(Rule rule)
        {
            if (rule != null)
            {
                _rules.Update(rule);
                if (rule.RuleHistory.Executed)
                {
                    rule.RuleHistory = new History();
                }
                _rules.Save();
                return RedirectToAction("RuleList");
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult DeleteRule(int id)
        {
            var rule = _rules.Find(id);
            if(rule != null)
            {
                return View(rule);
            }
            return NotFound();
        }

        [HttpPost]
        public IActionResult DeleteRuleId(int id)
        {
            var rule = _rules.Find(id);
            if (rule != null)
            {
                _rules.Delete(rule);
                _rules.Save();
                return RedirectToAction("RuleList");
            }
            return NotFound();
        }

        public async Task<IActionResult> RuleList()
        {
            var user = await _userManager.GetUserAsync(User);
            string userId = string.Empty;
            if (user != null)
            {
                userId = user.Id;
            }
            return View(_rules.GetAll().Where(rule=> (rule.UserId.ToString() == userId)).ToList());
        }

        public IActionResult ShowDetails(int id)
        {
            if (id > 0)
            {
                var rule = _rules.Find(id);
                if(rule != null)
                {
                    return View(rule.RuleHistory);
                }
                return NotFound();
            }
            else
            {
                return NotFound();
            }
        }

    }
}
