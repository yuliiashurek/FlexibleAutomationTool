using System;
using System.Collections.Generic;
using System.IO;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using FlexibleAutomationTool.BL.IServices;
using FlexibleAutomationTool.DL.Models;

namespace FlexibleAutomationTool.BL.Services.GenerateReport
{
    internal class GeneratingDocxReport : IReportGenerating
    {
        public void GenerateReport(Schedule schedule)
        {
            using (WordprocessingDocument doc = WordprocessingDocument.Create("schedule.docx", WordprocessingDocumentType.Document))
            {
                // Add a main part to the document.
                MainDocumentPart mainPart = doc.AddMainDocumentPart();

                // Create the document structure and elements.
                Document document = new Document();
                Body body = new Body();

                // Add a title to the document.
                Paragraph title = new Paragraph(new Run(new Text("Schedule Report")));
                title.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
                body.Append(title);

                // Add all fields of the Schedule class to the document.
                AddFieldToDocx(body, "ID", schedule.Id.ToString());
                AddFieldToDocx(body, "Date", schedule.Date.ToString());

                // Add Rules and Scripts
                AddSectionTitleToDocx(body, "Rules:");
                foreach (var rule in schedule.Rules)
                {
                    AddFieldToDocx(body, "Rule ID", rule.Id.ToString());
                    // Add more fields specific to Rule if needed.
                }

                AddSectionTitleToDocx(body, "Scripts:");
                foreach (var script in schedule.Scripts)
                {
                    AddFieldToDocx(body, "Script ID", script.Id.ToString());
                    // Add more fields specific to Script if needed.
                }

                // Save the changes to the document.
                document.Append(body);
                mainPart.Document = document;
            }
        }

        private void AddFieldToDocx(Body body, string field, string value)
        {
            Paragraph paragraph = new Paragraph(new Run(new Text(field + ": " + value)));
            body.Append(paragraph);
        }

        private void AddSectionTitleToDocx(Body body, string title)
        {
            Paragraph paragraph = new Paragraph(new Run(new Text(title)));
            paragraph.ParagraphProperties = new ParagraphProperties(new Justification() { Val = JustificationValues.Center });
            body.Append(paragraph);
        }
    }
}

