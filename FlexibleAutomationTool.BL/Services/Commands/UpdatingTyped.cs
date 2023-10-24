using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;

namespace FlexibleAutomationTool.BL.Services.Commands
{
    internal class UpdatingBook : Updating<Book>
    {
        public UpdatingBook(IRepository<Book> repository, Book entity) : base(repository, entity)
        {
        }
    }
    internal class UpdatingSchedule : Updating<Schedule>
    {
        public UpdatingSchedule(IRepository<Schedule> repository, Schedule entity) : base(repository, entity)
        {
        }
    }
    internal class UpdatingRule : Updating<Rule>
    {
        public UpdatingRule(IRepository<Rule> repository, Rule entity) : base(repository, entity)
        {
        }
    }
    internal class UpdatingScript : Updating<Script>
    {
        public UpdatingScript(IRepository<Script> repository, Script entity) : base(repository, entity)
        {
        }
    }
}
