using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class Loan
    {
        public Book Book { get; set; }
        public Reader Reader { get; set; }
        public DateTime LoanDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Loan(Book book, Reader reader)
        {
            Book = book;
            Reader = reader;
            LoanDate = DateTime.Now;
            ReturnDate = DateTime.MinValue;
        }
    }
}
