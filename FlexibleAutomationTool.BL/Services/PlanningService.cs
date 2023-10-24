using FlexibleAutomationTool.BL.IServices;
using FlexibleAutomationTool.DL.Models;
using FlexibleAutomationTool.DL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.Services
{
    internal class PlanningService : IPlanningService<Schedule>
    {
        private List<Schedule> _schedules;

        public PlanningService(IRepository<Schedule> schedules)
        {
            _schedules = schedules.GetAll().ToList();
           
        }
        public Schedule GetSchedule(DateTime date)
        {
            return _schedules.FirstOrDefault(item => item.Date == date);
        }

        public void SetEvent(Schedule schedule, Script item)
        {
            schedule.Scripts.Add(item);
        }

        public void SetEvent(Schedule schedule, Rule item)
        {
            schedule.Rules.Add(item);
        }
    }
}
