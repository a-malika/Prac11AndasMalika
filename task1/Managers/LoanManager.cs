using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class LoanManager
    {
        public Library Library { get; set; }
        public LoanManager(Library library)
        {
            Library = library;
        }
        public void IssueLoan(Book book, Reader reader)
        {
            if (book.AvailabilityStatus)
            {
                book.ChangeAvailabilityStatus(false);
                var loan = new Loan(book, reader);
                reader.BorrowedBooks.Add(loan);
                Library.LoanList.Add(loan);
            }
        }
        public void CompleteLoan(Book book, Reader reader)
        {
            var loan = Library.LoanList.Find(l => l.Book == book && l.Reader == reader && l.ReturnDate == DateTime.MinValue);
            if (loan != null)
            {
                book.ChangeAvailabilityStatus(true);
                loan.ReturnDate = DateTime.Now;
                reader.BorrowedBooks.Remove(loan);
            }
        }
    }
}
