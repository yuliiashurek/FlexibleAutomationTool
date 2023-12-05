using RuleInterpretatorService.Interfaces;

namespace RuleInterpretatorService.Services
{
    public class RuleInterpreter : IInterpretator
    {
        private readonly List<IExpressions> _expressions;
        private readonly Context _context;
        public RuleInterpreter(Context context)
        {
            _expressions = new List<IExpressions>() ;
            _expressions.Add(new EmailExpression());
            _expressions.Add(new TelegramExpression());
            _context = context;
        }

        public async Task InterpretRules()
        {
            foreach(var expression in _expressions)
            {
                await expression.InterpratAsync(_context);
            }
        }
    }
}
