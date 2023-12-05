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
            //TimerTaskAsync2();
            var deltaTime = 20000;
          // _timer = new Timer( new TimerCallback(async state => await TimerTaskAsync2(),  null, 1000, deltaTime));
            _bookRepository = books;
            _ruleRepository = rules;
        }

        //public void SetTimer()
        //{
        //    _timer = new System.Timers.Timer(2000);
        //    _timer.Elapsed += TimerTaskAsync;
        //    _timer.AutoReset = true;
        //    _timer.Enabled = true;
        //}

        //private void TimerTaskAsync(object timerState)
        //{
        //    TimerTaskAsync2(timerState);
        //}

        private async Task TimerTaskAsync2()
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
