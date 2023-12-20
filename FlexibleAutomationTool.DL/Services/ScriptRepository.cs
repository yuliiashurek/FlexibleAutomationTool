//using FlexibleAutomationTool.DL.Context;
//using FlexibleAutomationTool.DL.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FlexibleAutomationTool.DL.Repository
//{
//    internal class ScriptRepository : IRepository<Script>
//    {
//        private FlexibleAutomationToolContext _context;
//        private List<Script> _scripts;

//        public ScriptRepository(FlexibleAutomationToolContext context)
//        {
//            _context = context;
//            _scripts = _context.Scripts.ToList();
//        }
//        public void Create(Script script)
//        {
//            _scripts.Add(script);
//        }

//        public void Delete(int id)
//        {
//            _scripts.RemoveAll(item => item.Id == id);
//        }

//        public void Delete(Script item)
//        {
//            _scripts.Remove(item);
//        }

//        public Script? Find(int id)
//        {
//            return _scripts.FirstOrDefault(item => item.Id == id);
//        }

//        public IEnumerable<Script> GetAll()
//        {
//            return _scripts;
//        }

//        public void Save()
//        {
//            _context.SaveChanges();
//        }

//        public void Update(Script script)
//        {
//            Delete(script.Id);
//            Create(script);
//        }
//    }
//}
