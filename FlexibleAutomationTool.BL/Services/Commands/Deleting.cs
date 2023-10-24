using FlexibleAutomationTool.DL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.Services.Commands
{
    public class Deleting<T>
    {
        private readonly IRepository<T> _repository;
        private readonly T _entity;
        public Deleting(IRepository<T> repository, T entity)
        {
            _repository = repository;
            _entity = entity;
        }

        public void Execute()
        {
            _repository.Delete(_entity);
        }

        public void Undo()
        {
            _repository.Create(_entity);
        }
    }
}
