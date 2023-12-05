using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryCommandService.Commands
{
    public class CreateRuleCommmand : RuleCommand
    {
        public CreateRuleCommmand(string name, string action, string condition)
        {
            Name = Name;
            ConditionDate = ConditionDate;
            ConditionMessanger = ConditionMessanger;
            Action = Action;
        }
    }
}
