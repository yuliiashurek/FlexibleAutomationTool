using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.IServices
{
    internal interface ILogEventService
    {
        public void StartLogging();
        public void StopLogging();
    }

}
