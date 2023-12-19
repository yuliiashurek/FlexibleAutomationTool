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

        public async Task<bool> InterpretRules()
        {
            List<bool> allSent = new List<bool>();
            foreach(var expression in _expressions)
            {
                allSent.Add(await expression.InterpratAsync(_context));
            }
            return allSent.Any(p => p == true);
        }
    }
}
