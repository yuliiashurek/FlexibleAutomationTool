using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryCommandService.Commands
{
    public class CreateBookCommand : BookCommand
    {
        public CreateBookCommand(string title, string author, string bookUrl, string description)
        {
            Title = title;
            Author = author;
            BookUrl = bookUrl;
            Description = description;
        }
    }
}
