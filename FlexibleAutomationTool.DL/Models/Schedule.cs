namespace FlexibleAutomationTool.DL.Models
{
    public class Schedule : Entity
    {
        public DateTime Date { get; set; }
        public List<Rule> Rules { get; set; }
        public List<Script> Scripts { get; set; }

        private IReportGenerating reportStrategy;

        public void SetReportStrategy(IReportGenerating strategy)
        {
            reportStrategy = strategy;
        }

        public void GenerateReport()
        {
            reportStrategy?.GenerateReport(this);
        }
    }

}
