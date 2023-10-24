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
        private List<Book> _books;

        public BookRepository(FlexibleAutomationToolContext context) 
        { 
            _context = context;
            _books = _context.Books.ToList();
        }
        public void Create(Book book)
        {
            _books.Add(book);
        }

        public void Delete(int id)
        {
            _books.RemoveAll(item => item.Id == id);
        }

        public void Delete(Book item)
        {
            _books.Remove(item);
        }

        public Book? Find(int id)
        {
            return _books.FirstOrDefault(item => item.Id == id);
        }

        public IEnumerable<Book> GetAll()
        {
            return _books;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Book book)
        {
            Delete(book.Id);
            Create(book);
        }
    }
}
