using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.Interpretator
{
    public class RuleInterpreter
    {
        private readonly List<IExpressions> _expressions;
        private readonly Context _context;
        public RuleInterpreter(Context context)
        {
            _expressions = new List<IExpressions>() ;
            _expressions.Add(new CheckTimerExpressions());
            _expressions.Add(new CheckActiveUsersExpression());
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
