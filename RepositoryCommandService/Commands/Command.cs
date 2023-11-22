using RepositoryCommandService.Events;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryCommandService.Commands
{
    public abstract class Command : Message
    {
        public DateTime TimeStamp { get; protected set; }
        public Command()
        {
            TimeStamp = DateTime.Now;
        }
    }
}
