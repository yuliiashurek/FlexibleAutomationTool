using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.DL.Models
{
    public class Rule : Entity
    {
        public string Name { get; set; }
        public string Condition { get; set; }
        public string Action { get; set; }
    }
}
