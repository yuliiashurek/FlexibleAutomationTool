﻿using FlexibleAutomationTool.DL.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.AutomationTasks.Printers
{
    public class HtmlPrinter : IPrint
    {
        private Book _book;
        public HtmlPrinter(Book book) {
            _book = book;
        }
        public string Print()
        {
            return $"<h2>{_book.Title} by {_book.Author}</h2>\n<p>{_book.Description}</p>";
        }
    }
}
