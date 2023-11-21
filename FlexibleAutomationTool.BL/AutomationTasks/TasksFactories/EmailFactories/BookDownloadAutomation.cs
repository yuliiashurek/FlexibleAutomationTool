//using DocumentFormat.OpenXml.Spreadsheet;
//using FlexibleAutomationTool.BL.AutomationTasks.Printers;
//using FlexibleAutomationTool.BL.AutomationTasks.Senders;
//using FlexibleAutomationTool.DL.Models;

//namespace FlexibleAutomationTool.BL.AutomationTasks.TasksFactories.EmailFactories
//{
//    public class BookDownloadAutomation : TaskAbstract
//    {
//        private string _recepient;

//        public BookDownloadAutomation(string recipient) : base(recipient)
//        {
//            _recepient = recipient;
//        }

//        public override IPrint CreatePrinter(Book book)
//        {
//            return new EPubPrinter();
//        }

//        public override ISender CreateSender()
//        {
//            return new TorrentSender(_recepient);
//        }
//    }
//}
