
using FlexibleAutomationTool.DL.Models;

namespace FlexibleAutomationTool.BL.IServices
{
    internal interface IPlanningService<T>
    {
        public void SetEvent(T eventItem, Rule rule);
        public void SetEvent(T eventItem, Script script);
        public T GetSchedule(DateTime date);   
    }
}
