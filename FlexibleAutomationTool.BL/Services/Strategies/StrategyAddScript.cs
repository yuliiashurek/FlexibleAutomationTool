
using FlexibleAutomationTool.BL.IServices;
using FlexibleAutomationTool.DL.Models;

namespace FlexibleAutomationTool.BL.Services.Strategies
{
    internal class StrategyAddScript : IStrategy
    {
        private readonly IPlanningService<Schedule> _service;
        private readonly DateTime _date;
        private readonly Script _script;

        public StrategyAddScript(IPlanningService<Schedule> service, DateTime date, Script script) { 
            _service = service;
            _date = date;
            _script = script;
        }

        public void Algorithm()
        {
            _service.SetEvent(_service.GetSchedule(_date), _script);
        }
    }
}

