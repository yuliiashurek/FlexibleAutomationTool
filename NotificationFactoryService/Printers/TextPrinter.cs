namespace NotificationFactoryService.Printers
{
    public class TextPrinter : IPrint
    {
        private Book _book;
        public TextPrinter(Book book)
        {
            _book = book;
        }
        public string Print()
        {
            return $"NEW book : {_book.Title} by {_book.Author}";
        }
    }
}
