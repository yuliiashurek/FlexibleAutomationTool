using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;

namespace FlexibleAutomationTool.BL.Services.Commands
{
    internal class DeletingBook : Deleting<Book>
    {
        public DeletingBook(IRepository<Book> repository, Book entity) : base(repository, entity)
        {
        }
    }
    internal class DeletingSchedule : Deleting<Schedule>
    {
        public DeletingSchedule(IRepository<Schedule> repository, Schedule entity) : base(repository, entity)
        {
        }
    }
    internal class DeletingRule : Deleting<Rule>
    {
        public DeletingRule(IRepository<Rule> repository, Rule entity) : base(repository, entity)
        {
        }
    }
    internal class DeletingScript : Deleting<Script>
    {
        public DeletingScript(IRepository<Script> repository, Script entity) : base(repository, entity)
        {
        }
    }
}
