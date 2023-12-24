using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace FlexibleAutomationTool.DL.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Email { get; set; }   
        public virtual List<Rule> UserRules { get; set; }
        public long TelegramId {  get; set; }
    }
}
