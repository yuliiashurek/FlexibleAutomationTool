using FlexibleAutomationTool.BL.IServices;

namespace FlexibleAutomationTool.BL.Services.Strategies
{
    internal class Context
    {
        private readonly IStrategy _strategy;
        public Context(IStrategy strategy) 
        {
            _strategy = strategy;
        }

        public void ExecuteAlgorithm()
        {
            _strategy.Algorithm();
        }
    }
}
