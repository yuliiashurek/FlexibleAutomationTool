using FlexibleAutomationTool.DL.Models;
using System.Text;

namespace NotificationFactoryService.Printers
{
    public class TextPrinter : IPrint
    {
        private IEnumerable<Book> _books;
        public TextPrinter(IEnumerable<Book> books)
        {
            _books = books;
        }
        public string Print()
        {
            StringBuilder builder = new StringBuilder();

            foreach (var book in _books)
            {
                builder.AppendLine($"NEW book : {book.Title} by {book.Author}");
                builder.AppendLine();
            }

            return builder.ToString();
        }
    }
}
