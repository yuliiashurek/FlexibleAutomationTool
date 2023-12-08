using DocumentFormat.OpenXml.Office2010.Excel;
using FlexibleAutomationTool.DL.Context;
using FlexibleAutomationTool.DL.Models;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.DL.Repository
{
    public class BookRepository : IRepository<Book>
    {
        private FlexibleAutomationToolContext _context;

        public BookRepository(FlexibleAutomationToolContext context) 
        { 
            _context = context;
        }
        public void Create(Book book)
        {
            lock (_context)
            {
                _context.Books.Add(book);
            }
        }

        public void Delete(int id)
        {
            lock (_context)
            {
                var book = _context.Books.FirstOrDefault<Book>(book => book.Id == id);
                _context.Books.Remove(book);
            }
        }

        public void Delete(Book item)
        {
            lock (_context)
            {
                _context.Books.Remove(item);
            }
        }

        //todo add find by author and title
        public Book? Find(int id)
        {
            lock (_context)
            {
                return _context.Books.FirstOrDefault<Book>(book => book.Id == id);
            }
        }

        public IEnumerable<Book> GetAll()
        {
            lock (_context)
            {
                return _context.Books.ToList();
            }
        }

        public void Save()
        {
            lock (_context)
            {
                _context.SaveChanges();
            }
        }


        public void Update(Book book)
        {
            Delete(book.Id);
            Create(book);
        }
    }
}
