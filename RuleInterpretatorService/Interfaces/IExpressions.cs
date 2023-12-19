using RuleInterpretatorService.Services;
using System;
namespace RuleInterpretatorService.Interfaces
{
    public interface IExpressions
    {
        public Task<bool> InterpratAsync(Context context);
    }
}
