using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.DL.Repository
{
    public interface IRepository<T>
    {

        public void Create(T item);

        public void Update(T item);
        public void Delete(int id);
        public void Delete(T item);

        public T? Find(int id);
        public IEnumerable<T> GetAll();
        public void Save();
        
    }
}
