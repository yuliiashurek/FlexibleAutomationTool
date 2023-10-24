using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;

namespace FlexibleAutomationTool.BL.Services.Commands
{
    public class Updating<T> where T : Entity
    {
        private readonly IRepository<T> _repository;
        private readonly T _entity;
        private T _oldEntity;
        
        public Updating(IRepository<T> repository, T entity)
        {
            _repository = repository;
            _entity = entity;
        }

        public void Execute()
        {
            _oldEntity = _repository.Find(_entity.Id);
            _repository.Update(_entity);
        }

        public void Undo()
        {
            _repository.Update(_oldEntity);
        }
    }
}
