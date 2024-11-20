using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class Library
    {
        public List<Book> BookList { get; set; }
        public List<User> UserList { get; set; }
        public List<Loan> LoanList { get; set; }
        public List<Report> ReportList { get; set; }
        public Library()
        {
            BookList = new List<Book>();
            UserList = new List<User>();
            LoanList = new List<Loan>();
            ReportList = new List<Report>();
        }
    }
}
