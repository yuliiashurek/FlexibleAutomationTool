using RuleInterpretatorService.Services;
using System;
namespace RuleInterpretatorService.Intefaces
{
    public interface IExpressions
    {
        public Task InterpratAsync(Context context);
    }
}
