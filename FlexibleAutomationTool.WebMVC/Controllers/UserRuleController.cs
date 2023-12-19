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

        public UserRuleController(IRepository<Rule> rules, IMediatorService mediator, UserManager<IdentityUser> userManager) 
        {
            _mediator = mediator;
            _rules = rules;
            _userManager = userManager;
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
                if (user != null)
                {
                    string userId = user.Id;

                    rule.UserId = new Guid(userId);
                }
                //var createRuleCommand = new CreateRuleCommmand(rule.Name, rule.ConditionDate, rule.ConditionMessanger, rule.Action);
                //_mediator.SendCommand(createRuleCommand);
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


    }
}
