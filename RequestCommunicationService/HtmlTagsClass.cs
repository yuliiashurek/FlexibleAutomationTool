namespace RequestCommunicationService
{
    public class HtmlTagsClass
    {
        public string Name { get; set; } = ".//a[@class = 'product__name']";
        public string Author { get; set; } = ".//div[@class = 'product__author']";

        public string Node { get; set; } = "//div[@class = 'product']";

    }
}
