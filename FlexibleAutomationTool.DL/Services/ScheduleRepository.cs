using FlexibleAutomationTool.DL.Context;
using FlexibleAutomationTool.DL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.DL.Repository
{
    public class ScheduleRepository : IRepository<Schedule>
    {
        private FlexibleAutomationToolContext _context;
        private List<Schedule> _schedules;

        public ScheduleRepository(FlexibleAutomationToolContext context)
        {
            _context = context;
            _schedules = _context.Schedules.ToList();
        }
        public void Create(Schedule item)
        {
            _schedules.Add(item);
        }

        public void Delete(int id)
        {
            _schedules.RemoveAll(item => item.Id == id);
        }

        public void Delete(Schedule item)
        {
            _schedules.Remove(item);
        }

        public Schedule? Find(int id)
        {
            return _schedules.FirstOrDefault(s => s.Id == id);
        }

        public IEnumerable<Schedule> GetAll()
        {
            return _schedules;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Schedule item)
        {
            Delete(item.Id);
            Create(item);
        }
    }
}
