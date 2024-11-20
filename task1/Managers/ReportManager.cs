using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class ReportManager
    {
        public Library Library { get; set; }
        public ReportManager(Library library)
        {
            Library = library;
        }
        public string CreateReport(string type)
        {
            var report = new Report(type);
            Library.ReportList.Add(report);
            return report.GenerateReport(type, Library.LoanList);
        }
    }
}
