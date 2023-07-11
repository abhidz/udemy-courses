using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern.PdfExcelApplication
{
    public class PdfExcelReport
    {
        public string Header { get; set; }
        public string Footer { get; set; }

    }

    public abstract class ReportBuilder
    {
        public abstract void setHeader(PdfExcelReport report);
        public abstract void setFooter(PdfExcelReport report);
    }

    public class PdfReport : ReportBuilder
    {
        public override void setFooter(PdfExcelReport report)
        {
            report.Header = " PDF Header";
        }

        public override void setHeader(PdfExcelReport report)
        {
            report.Footer = " PDF Footer";
        }
    }

    public class ExcelReport : ReportBuilder
    {
        public override void setFooter(PdfExcelReport report)
        {
            report.Header = " Excel Header";
        }

        public override void setHeader(PdfExcelReport report)
        {
            report.Footer = " Excel Footer";
        }
    }

    public class ReportDirector
    {
        public void DisplayReport(ReportBuilder report)
        {
            var obj = new PdfExcelReport();
            report.setHeader(obj);
            report.setFooter(obj);
            Console.WriteLine(obj.Header + " " + obj.Footer);
        }

    }

}