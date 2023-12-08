using FlexibleAutomationTool.DL.Models;
using System.Text;

namespace NotificationFactoryService.Printers
{
    public class HtmlPrinter : IPrint
    {
        private IEnumerable<Book> _books;
        public HtmlPrinter(IEnumerable<Book> books) {
            _books = books;
        }
        public string Print()
        {
            StringBuilder htmlBuilder = new StringBuilder();

            foreach (var book in _books)
            {
                htmlBuilder.AppendLine($"<h2>{book.Title} by {book.Author}</h2>");
                htmlBuilder.AppendLine();
            }

            return htmlBuilder.ToString();
        }

    }
}
