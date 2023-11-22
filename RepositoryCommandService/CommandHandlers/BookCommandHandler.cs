using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using MediatR;
using RepositoryCommandService.Commands;

namespace RepositoryCommandService.CommandHandlers
{
    public class BookCommandHandler : IRequestHandler<BookCommand, bool>
    {
        private readonly IRepository<Book> _bookRepository;

        public BookCommandHandler(IRepository<Book> bookRepository) 
        { 
            _bookRepository = bookRepository;
        }

        public Task<bool> Handle(BookCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var book = new Book()
                {
                    Title = request.Title,
                    Author = request.Author,
                    BookUrl = request.BookUrl,
                    Description = request.Description,
                };

                _bookRepository.Create(book);
                _bookRepository.Save();
            }
            catch
            {
                Task.FromResult(false);
            }
           
            return Task.FromResult(true);
        }
    }
}
