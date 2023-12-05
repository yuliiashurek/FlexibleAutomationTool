using FlexibleAutomationTool.DL.Models;

namespace RequestCommunicationService.Interface
{
    public interface IParseHtmlService<T>
    {
        public delegate void newBookDelegate(Book book);
        public Task<List<Book>> ParseHtmlToItem(HtmlTagsClass model = null);
        //public bool IsInRepository(T item);
        public void AddItem(T item);
    }
}
