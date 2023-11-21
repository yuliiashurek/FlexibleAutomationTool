using FlexibleAutomationTool.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.AutomationTasks.Printers
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
