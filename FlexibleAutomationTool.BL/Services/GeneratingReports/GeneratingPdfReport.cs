using FlexibleAutomationTool.BL.IServices;
using FlexibleAutomationTool.DL.Models;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleAutomationTool.BL.Services.GenerateReport
{
    public class GeneratingPdfReport : IReportGenerating
    {
        public void GenerateReport(Schedule schedule)
        {
            using (var document = new Document())
            {
                var pdfWriter = PdfWriter.GetInstance(document, new FileStream("schedule.pdf", FileMode.Create));
                document.Open();

                // Add content to the PDF document, including schedule data.
                document.Add(new Paragraph("Schedule Report"));
                document.Add(new Paragraph($"ID: {schedule.Id}"));
                document.Add(new Paragraph($"Date: {schedule.Date.ToString()}"));

                // Add Rules
                if (schedule.Rules != null && schedule.Rules.Count > 0)
                {
                    document.Add(new Paragraph("Rules:"));
                    foreach (var rule in schedule.Rules)
                    {
                        document.Add(new Paragraph($"- {rule.Name}: if {rule.Condition} then {rule.Action}"));
                    }
                }

                // Add Scripts
                if (schedule.Scripts != null && schedule.Scripts.Count > 0)
                {
                    document.Add(new Paragraph("Scripts:"));
                    foreach (var script in schedule.Scripts)
                    {
                        document.Add(new Paragraph($"- {script.Name}"));
                    }
                }

                document.Close();
            }
        }
    }
    }
