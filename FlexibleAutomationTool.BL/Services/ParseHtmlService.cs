using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FlexibleAutomationTool.BL.IServices;
using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using HtmlAgilityPack;

namespace FlexibleAutomationTool.BL.Services
{
    internal class ParseHtmlService : IParseHtmlService<Book>
    {
        private readonly string _url;
        private readonly IRepository<Book> _books;
        public ParseHtmlService(string url, IRepository<Book> books) 
        {
            _url = url;
            _books = books;
        }

        public Book ParseHtmlToItem()
        {
            return null;
        }

        public bool IsInRepository(Book book)
        {
            return _books.Find(book.Id) != null;
        }

        public void AddItem(Book book)
        {
            _books.Create(book);
        }
    }
}
