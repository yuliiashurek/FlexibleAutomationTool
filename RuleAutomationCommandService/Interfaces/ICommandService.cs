using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RuleAutomationCommandService.Interfaces
{
    public interface ICommandService
    {
        public void Execute();
        public void Undo();
    }
}


