using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryCommandService.Commands
{
    public class RuleCommand : Command
    {
        public string Name { get; protected set; }
        public string Condition { get; protected set; }
        public string Action { get; protected set; }
    }
}
