
using FlexibleAutomationTool.BL.IServices;
using FlexibleAutomationTool.DL.Models;

namespace FlexibleAutomationTool.BL.Services.Strategies
{
    internal class StrategyAddRule : IStrategy
    {
        private readonly IPlanningService<Schedule> _service;
        private readonly DateTime _date;
        private readonly Rule _rule;

        public StrategyAddRule(IPlanningService<Schedule> service, DateTime date, Rule rule)
        {
            _service = service;
            _date = date;
            _rule = rule;
        }

        public void Algorithm()
        {
            _service.SetEvent(_service.GetSchedule(_date), _rule);
        }
    }
}

