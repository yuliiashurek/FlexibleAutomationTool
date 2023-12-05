using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleInterpretatorService.Interfaces
{
    public interface IInterpretator
    {
        public Task InterpretRules();
    }
}
