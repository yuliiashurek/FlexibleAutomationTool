namespace RequestCommunicationService.Interface
{
    public interface IParseHtmlService<T>
    {

        public Task ParseHtmlToItem(HtmlTagsClass model = null);
        public bool IsInRepository(T item);
        public void AddItem(T item);
    }
}
