using FlexibleAutomationTool.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.AutomationTasks.Printers
{
    public interface IPrint
    {
        public string Print(Book book);
    }
}
