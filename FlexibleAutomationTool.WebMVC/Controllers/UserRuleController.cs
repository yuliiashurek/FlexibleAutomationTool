using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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

        public UserRuleController(IRepository<Rule> rules, IMediatorService mediator) 
        {
            _mediator = mediator;
            _rules = rules;
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
        public IActionResult CreateRule(Rule rule)
        {
            if (rule != null)
            {
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

        public IActionResult RuleList()
        {
            return View(_rules.GetAll());
        }
    }
}
