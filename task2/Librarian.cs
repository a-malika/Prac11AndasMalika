using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class Librarian
    {
        private ICatalog catalog;
        private IAccountingSystem accountingSystem;
        public Librarian(ICatalog catalog, IAccountingSystem accountingSystem)
        {
            this.catalog = catalog;
            this.accountingSystem = accountingSystem;
        }
        public void IssueBook(string title, Reader reader)
        {
            var book = catalog.SearchByTitle(title);
            if (book != null)
            {
                accountingSystem.RecordIssuedBook(book, reader);
            }
            else
            {
                Console.WriteLine($"Невозможно выдать книгу. Книга '{title}' не найдена в каталоге.");
            }
        }
        public void ReturnBook(string title, Reader reader)
        {
            var book = catalog.SearchByTitle(title);
            if (book != null)
            {
                accountingSystem.RecordReturnedBook(book, reader);
            }
            else
            {
                Console.WriteLine($"Невозможно вернуть книгу. Книга '{title}' не найдена в каталоге.");
            }
        }
    }
}
