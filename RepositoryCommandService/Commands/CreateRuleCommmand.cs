using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryCommandService.Commands
{
    public class CreateRuleCommmand : RuleCommand
    {
        public CreateRuleCommmand(string name, DateTime conditionDate, string conditionMessanger, string action)
        {
            Name = name;
            ConditionDate = conditionDate;
            ConditionMessanger = conditionMessanger;
            Action = action;
        }
    }
}
