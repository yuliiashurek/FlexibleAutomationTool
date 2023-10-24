using FlexibleAutomationTool.BL.IServices;
using FlexibleAutomationTool.DL.Models;
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.Services.GenerateReport
{
    public class GeneratingHtmlReport : IReportGenerating
    {
        public void GenerateReport(Schedule schedule)
        {
            var htmlContent = new StringBuilder();
            htmlContent.Append("<html><head><title>Schedule Report</title></head><body>");

            htmlContent.Append("<h1>Schedule Report</h1>");
            htmlContent.Append("<p>ID: " + schedule.Id + "</p>");
            htmlContent.Append("<p>Date: " + schedule.Date + "</p>");

            htmlContent.Append("<h2>Rules:</h2>");
            htmlContent.Append("<ul>");
            foreach (var rule in schedule.Rules)
            {
                htmlContent.Append("<li>Rule ID: " + rule.Id + "</li>");
                // Add more fields specific to Rule if needed.
            }
            htmlContent.Append("</ul>");

            htmlContent.Append("<h2>Scripts:</h2>");
            htmlContent.Append("<ul>");
            foreach (var script in schedule.Scripts)
            {
                htmlContent.Append("<li>Script ID: " + script.Id + "</li>");
                // Add more fields specific to Script if needed.
            }
            htmlContent.Append("</ul>");

            // Add more fields as needed.

            htmlContent.Append("</body></html>");

            File.WriteAllText("schedule.html", htmlContent.ToString());
        }
    }
}
