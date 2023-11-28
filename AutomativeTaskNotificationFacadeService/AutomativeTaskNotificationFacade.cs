namespace AutomativeTaskNotificationFacadeService
{
    public class AutomativeTaskMailing
    {
        FlexibleAutomationToolContext _flexibleAutomationToolContext;
        private string _recepient;

        public AutomativeTaskMailing(FlexibleAutomationToolContext flexibleAutomationToolContext, string recepient= "juliysik@gmail.com")
        {
            _flexibleAutomationToolContext = flexibleAutomationToolContext;
            _recepient = recepient;
        }

        public async Task MailingNewBooksAsync()
        {
            using (_flexibleAutomationToolContext)
            {
                IRepository<Book> bookRepository = new BookRepository(_flexibleAutomationToolContext);
                IParseHtmlService parser = new ParseHtmlService(bookRepository);
                parser.SendEmailEvent += SendAll;
                //parser.SendEmailEvent += SendTelegramNotificationAsync;
                await parser.ParseHtmlToItem();
            }
        }

        private void SendAll(Book book)
        {
            SendEmail(book);
            SendTelegramNotificationAsync(book);
        }

        private void SendEmail(Book book)
        {
            TaskAbstract taskFactory = new HtmlEmailFactory();
            var printer = taskFactory.CreatePrinter(book);
            var sender = taskFactory.CreateSender();
            sender.Send(printer);
        }

        private void SendTelegramNotificationAsync(Book book)
        {
            TaskAbstract taskFactory = new TextTelegramFactory();
            var printer = taskFactory.CreatePrinter(book);
            var sender = taskFactory.CreateSender();
            sender.Send(printer);
        }
    }
}
