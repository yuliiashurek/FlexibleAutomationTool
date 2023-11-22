using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryCommandService.Commands
{
    public class BookCommand : Command
    {
        public string Title { get; protected set; }
        public string Author { get; protected set; }
        public string? BookUrl { get; protected set; }
        public string? Description { get; protected set; }
    }
}
