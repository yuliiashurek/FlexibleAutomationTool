using FlexibleAutomationTool.DL.Models;
using RequestCommunicationService.Services;
using System.Data;

namespace RuleInterpretatorService.Services
{
    public class Context
    {
        public DateTime DateAction { get; set; }
        public string WhereToSend { get; set; }
        public IEnumerable<Book> Books { get; set; }

        //public DateTime Time { get; set; } = DateTime.Now.AddMinutes(-3);
        ////public Action ToDo {  get; set; } 
        ////private bool isActive;
        //public bool usersAreActive
        //{
        //    get => _telegramActiveUsersService.isActiveUsers().Result;
        //    //private set
        //    //{
        //    //    isActive = _telegramActiveUsersService.isActiveUsers().Result;
        //    //}
        //}
        ////public string Recipient { get; set; } = "juliysik@gmail.com";
        //public string Recipient { get; set; } 
    }
}
