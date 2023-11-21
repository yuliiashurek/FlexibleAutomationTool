using FlexibleAutomationTool.BL.IServices;
using FlexibleAutomationTool.DL.Models;

namespace FlexibleAutomationTool.BL.Services.Strategies
{
    internal class StrategyAddBook : IStrategy
    {
        private readonly IParseHtmlService<Book> _parseHtmlService;

        public StrategyAddBook(IParseHtmlService<Book> parseHtmlService)
        {
            _parseHtmlService = parseHtmlService;
        }
        public void Algorithm()
        {
            var book = _parseHtmlService.ParseHtmlToItem();
            if (!_parseHtmlService.IsInRepository(null))
            {
                _parseHtmlService.AddItem(null);
            }
        }
    }
}


