using FlexibleAutomationTool.DL.Context;
using FlexibleAutomationTool.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.DL.Repository
{
    public class RuleRepository : IRepository<Rule>
    {
        private FlexibleAutomationToolContext _context;

        public RuleRepository(FlexibleAutomationToolContext context)
        {
            _context = context;
        }
        public void Create(Rule rule)
        {
            _context.Rules.Add(rule);
        }

        public void Delete(int id)
        {
            var rule = _context.Rules.FirstOrDefault<Rule>(rule => rule.Id == id);
            _context.Rules.Remove(rule);
        }

        public void Delete(Rule rule)
        {
            _context.Rules.Remove(rule);
        }

        //todo add find by author and title
        public Rule? Find(int id)
        {
            return _context.Rules.FirstOrDefault<Rule>(rule => rule.Id == id);
        }

        public IEnumerable<Rule> GetAll()
        {
            lock (_context)
            {
            return _context.Rules.ToList();
            }
        }

        public void Save()
        {
            lock (_context)
            {
                _context.SaveChanges();
            }
        }

        public void Update(Rule rule)
        {
            Delete(rule.Id);
            //_context.Update(_context.History);
            Create(rule);
        }
    }
}
