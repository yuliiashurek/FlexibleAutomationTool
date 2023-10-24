using FlexibleAutomationTool.BL.IServices;
using FlexibleAutomationTool.DL.Repository;

namespace FlexibleAutomationTool.BL.Services.Commands
{
    public class Adding<T> : ICommand
    {
        private readonly IRepository<T> _repository;
        private readonly T _entity;
        public Adding(IRepository<T> repository, T entity)
        {
            _repository = repository;
            _entity = entity;
        }

        public void Execute()
        {
            _repository.Create(_entity);
        }

        public void Undo()
        {
            _repository.Delete(_entity);
        }
    }
}
