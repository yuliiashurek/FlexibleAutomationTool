using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.DL.Models
{
    public class Mouse : Entity
    {
        public int X { get; set; }
        public int Y { get; set; }  
        public MouseValueKey ValueKey;

    }
}
