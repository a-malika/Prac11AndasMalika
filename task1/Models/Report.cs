using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class Report
    {
        public string Title { get; set; }
        public DateTime GeneratedAt { get; set; }
        public Report(string title)
        {
            Title = title;
            GeneratedAt = DateTime.Now;
        }
        public string GenerateReport(string type, List<Loan> loans)
        {
            // Реализация генерации отчета
            return $"{type} Report generated at {GeneratedAt}";
        }
    }
}
