using FlexibleAutomationTool.BL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.Interpretator
{
    public class Context
    {
        public DateTime Time { get; set; } = DateTime.Now.AddMinutes(-3);
        private bool isActive;
        public bool usersAreActive
        {
            get => new TelegramActiveUsersService().isActiveUsers().Result;
            private set
            {
                var tg = new TelegramActiveUsersService();
                isActive = tg.isActiveUsers().Result;
            }
        }
        //public string Recipient { get; set; } = "juliysik@gmail.com";
        public string Recipient { get; set; } 
    }
}
