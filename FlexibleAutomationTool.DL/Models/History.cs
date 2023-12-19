using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.DL.Models
{
    public class History
    {
        public int Id {  get; set; }
        public string? Message {  get; set; }
        public DateTime? DateExecution { get; set; }
        public bool Executed { get; set; } = false;
    }
}
