using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    class Program
    {
        static void Main(string[] args)
        {
            ICatalog catalog = new Catalog();
            IAccountingSystem accountingSystem = new AccountingSystem();
            Librarian librarian = new Librarian(catalog, accountingSystem);

            var book1 = new Book("Война и мир", "Лев Толстой", "Роман", "12345");
            var book2 = new Book("Преступление и наказание", "Федор Достоевский", "Роман", "67890");
            var reader = new Reader("Иван", "Иванов", "001");

            catalog.AddBook(book1);
            catalog.AddBook(book2);

            librarian.IssueBook("Война и мир", reader);
            librarian.ReturnBook("Война и мир", reader);
            librarian.IssueBook("Преступление и наказание", reader);

            accountingSystem.ShowTransactionHistory();
        }
    }
}
