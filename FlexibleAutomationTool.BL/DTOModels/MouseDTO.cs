using FlexibleAutomationTool.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.DTOModels
{
    internal class MouseDTO
    {
        public int Id { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public MouseValueKey ValueKey;
    }
}
