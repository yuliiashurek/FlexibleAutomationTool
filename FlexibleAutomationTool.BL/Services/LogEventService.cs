using FlexibleAutomationTool.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Threading.Tasks;


namespace FlexibleAutomationTool.BL.Services
{
    internal class LogEventService
    {
        private Script _script;

        public LogEventService(Script scripts)
        {
            _script = scripts;
        }

        public void StartLogging()
        {

        }

        public void StopLogging() 
        { 

        }

        private void RecordKeyDown(object sender, EventArgs eventArgs)
        {
            _script.Keys.Enqueue((Key)sender);
        }

        private void RecordKeyUp(object sender, EventArgs eventArgs)
        {
            _script.Keys.Enqueue((Key)sender);
        }

        private void RecordMouseClick(object sender, EventArgs eventArgs)
        {
        }

        private void RecordMouseOneClickLeft(object sender, EventArgs eventArgs)
        {

        }

        private void RecordMouseOneClickRight(object sender, EventArgs eventArgs)
        {

        }

        private void RecordMouseDoubleClickLeft(object sender, EventArgs eventArgs)
        {

        }
    }
}
