using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.DL.Models
{
    public class Book : Entity
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
    }
}
