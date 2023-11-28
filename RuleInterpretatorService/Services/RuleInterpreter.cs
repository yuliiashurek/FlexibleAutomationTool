﻿using RuleInterpretatorService.Intefaces;

namespace RuleInterpretatorService.Services
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
