//using FlexibleAutomationTool.DL.Context;
//using FlexibleAutomationTool.DL.Models;
//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace FlexibleAutomationTool.DL.Repository
//{
//    public class ScheduleRepository : IRepository<Schedule>
//    {
//        private FlexibleAutomationToolContext _context;

//        public ScheduleRepository(FlexibleAutomationToolContext context)
//        {
//            _context = context;
//        }
//        public void Create(Schedule schedule)
//        {
//            _context.Schedules.Add(schedule);
//        }

//        public void Delete(int id)
//        {
//            var schedule = _context.Schedules.FirstOrDefault<Schedule>(schedule => schedule.Id == id);
//            _context.Schedules.Remove(schedule);
//        }

//        public void Delete(Schedule item)
//        {
//            _context.Schedules.Remove(item);
//        }

//        //todo add find by author and title
//        public Schedule? Find(int id)
//        {
//            return _context.Schedules.FirstOrDefault<Schedule>(schedule => schedule.Id == id);
//        }

//        public IEnumerable<Schedule> GetAll()
//        {
//            return _context.Schedules.ToList();
//        }

//        public void Save()
//        {
//            _context.SaveChanges();
//        }

//        public void Update(Schedule schedule)
//        {
//            Delete(schedule.Id);
//            Create(schedule);
//        }

//    }
//}
