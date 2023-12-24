using DocumentFormat.OpenXml.Drawing.Diagrams;
using FlexibleAutomationTool.DL.Context;
using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using RequestCommunicationService.Services;
using RuleInterpretatorService.Services;

namespace AutomativeTaskNotificationFacadeService
{
    public class ScheduleNotificationFacadeService
    {
        IRepository<Book> _bookRepository;
        IRepository<FlexibleAutomationTool.DL.Models.Rule> _ruleRepository;
        private System.Timers.Timer _timer;
        private List<Book> _newBooks = new List<Book>();

        public ScheduleNotificationFacadeService()
        {
            var deltaTime = 20000;
            FlexibleAutomationToolContext context = new FlexibleAutomationToolContext();
            _bookRepository = new BookRepository(context);
            _ruleRepository = new RuleRepository(context); ;
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
            //ParseHtmlService parser = new ParseHtmlService(_bookRepository);
            var contextList = CreateContext(_bookRepository.GetAll());//await parser.ParseHtmlToItem());
             foreach (var context in contextList)
             {
                 var interpretator = new RuleInterpreter(context);
                 var outContext = await interpretator.InterpretRules();
                 if (outContext.Rule.RuleHistory.Executed)
                 {
                     //_newBooks.Clear();

                    _ruleRepository.Update(outContext.Rule);
                }
             }
             _ruleRepository.Save();

        }

        private IEnumerable<Context> CreateContext(IEnumerable<Book> books)
        {
            _newBooks.AddRange(books);
            var contextList = new List<Context>();

            var filteredRules = _ruleRepository.GetAll().Where(rule => !rule.RuleHistory.Executed).ToList();

            foreach (var rule in filteredRules)
            {
                contextList.Add(new Context() { Books = _newBooks, Rule = rule });
            }
            return contextList;
        }
    }
}
