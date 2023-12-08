using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using RequestCommunicationService.Services;
using RuleInterpretatorService.Services;
using System.Timers;
using Telegram.Bot.Requests;

namespace AutomativeTaskNotificationFacadeService
{
    public class ScheduleNotificationFacadeService
    {
        IRepository<Book> _bookRepository;
        IRepository<Rule> _ruleRepository;
        private System.Timers.Timer _timer;

        public ScheduleNotificationFacadeService(IRepository<Book> books, IRepository<Rule> rules)
        {
            var deltaTime = 20000;
            _bookRepository = books;
            _ruleRepository = rules;
            _timer = new System.Timers.Timer();
            _timer.Elapsed += async (sender, e) =>
            {
                await TimerTaskAsync();
            };
            _timer.Interval = 10000; 
            _timer.Start();
        }

        public async Task TimerTaskAsync()
        {
             ParseHtmlService parser = new ParseHtmlService(_bookRepository);
             var contextList = CreateContext(await parser.ParseHtmlToItem());
             foreach (var context in contextList)
             {
                 var interpretator = new RuleInterpreter(context);
                 await interpretator.InterpretRules();
             }
        }

        private IEnumerable<Context> CreateContext(IEnumerable<Book> books)
        {
            var contextList = new List<Context>();
            foreach (var rule in _ruleRepository.GetAll())
            {
                contextList.Add(new Context() { Books = books, DateAction = rule.ConditionDate, WhereToSend = rule.ConditionMessanger });
            }
            return contextList;
        }
    }
}
