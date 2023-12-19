using RuleInterpretatorService.Interfaces;

namespace RuleInterpretatorService.Services
{
    public class RuleInterpreter : IInterpretator
    {
        private readonly List<IExpressions> _expressions;
        private readonly Context _context;
        public RuleInterpreter(Context context)
        {
            _expressions = new List<IExpressions>
            {
                new EmailExpression(),
                new TelegramExpression()
            };
            _context = context;
        }

        public async Task<Context> InterpretRules()
        {
            foreach(var expression in _expressions)
            {
                await expression.InterpratAsync(_context);
            }
            return _context;
            //return allSent.Any(p => p == true);
        }
    }
}
