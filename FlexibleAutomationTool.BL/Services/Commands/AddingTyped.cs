using FlexibleAutomationTool.BL.IServices;
using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.Services.Commands
{
    internal class AddingBook : Adding<Book>
    {
        public AddingBook(IRepository<Book> repository, Book entity) : base(repository, entity)
        {
        }
    }
    internal class AddingSchedule : Adding<Schedule>
    {
        public AddingSchedule(IRepository<Schedule> repository, Schedule entity) : base(repository, entity)
        {
        }
    }
    internal class AddingRule : Adding<Rule>
    {
        public AddingRule(IRepository<Rule> repository, Rule entity) : base(repository, entity)
        {
        }
    }
    internal class AddingScript : Adding<Script>
    {
        public AddingScript(IRepository<Script> repository, Script entity) : base(repository, entity)
        {
        }
    }
}
