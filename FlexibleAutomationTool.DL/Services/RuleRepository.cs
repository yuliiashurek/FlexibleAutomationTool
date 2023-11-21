using FlexibleAutomationTool.DL.Context;
using FlexibleAutomationTool.DL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.DL.Repository
{
    internal class RuleRepository : IRepository<Rule>
    {
        private FlexibleAutomationToolContext _context;
        private List<Rule> _rules;

        public RuleRepository(FlexibleAutomationToolContext context)
        {
            _context = context;
            _rules = _context.Rules.ToList();
        }
        public void Create(Rule rule)
        {
            _rules.Add(rule);
        }

        public void Delete(int id)
        {
            _rules.RemoveAll(item => item.Id == id);
        }

        public void Delete(Rule item)
        {
            _rules.Remove(item);
        }

        public Rule? Find(int id)
        {
            return _rules.FirstOrDefault(item => item.Id == id);
        }

        public IEnumerable<Rule> GetAll()
        {
            return _rules;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Rule rule)
        {
            Delete(rule.Id);
            Create(rule);
        }
    }
}
