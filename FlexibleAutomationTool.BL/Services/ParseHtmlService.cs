//using DocumentFormat.OpenXml.Presentation;
//using FlexibleAutomationTool.BL.AutomationTasks.Printers;
//using FlexibleAutomationTool.BL.IServices;
//using FlexibleAutomationTool.DL.Models;
//using FlexibleAutomationTool.DL.Repository;
//using HtmlAgilityPack;

//namespace FlexibleAutomationTool.BL.Services
//{
//    public class ParseHtmlService : IParseHtmlService<Book>
//    {
//        private readonly string _url;
//        private readonly IRepository<Book> _books;
//        public delegate void newBookDelegate(Book book);
//        public event newBookDelegate? SendEmailEvent;
        
//        public ParseHtmlService(IRepository<Book> books, string url = "https://book-ye.com.ua/") 
//        {
//            _url = url;
//            _books = books;
//        }

//        public bool IsInRepository(Book book)
//        {
//            return _books.Find(book.Id) != null;
//        }

//        public void AddItem(Book book)
//        {
//            _books.Create(book);
//        }

//        public async Task ParseHtmlToItem(HtmlTagsClass model = null)
//        {
//            if(model == null)
//            {
//                model = new HtmlTagsClass();
//            }
//            using (HttpClient httpClient = new HttpClient())
//            {
//                string htmlContent = await httpClient.GetStringAsync(_url);
//                var docHtml = new HtmlDocument();
//                docHtml.LoadHtml(htmlContent);

//                var divElements = docHtml.DocumentNode.SelectNodes(model.Node);
//                if (divElements != null)
//                {
//                    var books = _books.GetAll();
//                    foreach (var a in divElements)
//                    {
//                        var titleElement = a.SelectSingleNode(model.Name);
//                        var authorElement = a.SelectSingleNode(model.Author);
//                        if (titleElement != null && authorElement != null)
//                        {
//                            string title = titleElement.InnerText.Trim();
//                            string author = authorElement.InnerText.Trim();
//                            Book? book = books.FirstOrDefault(book => book.Title == title && book.Author == author);
//                            if(book == null)
//                            {
//                                var bb = new Book() { Title = title, Author = author };
//                                _books.Create(bb);
//                                SendEmailEvent?.Invoke(bb);
//                            }
//                        }
//                    }
//                    _books.Save();
//                }
//            }
//        }
//    }
//}
