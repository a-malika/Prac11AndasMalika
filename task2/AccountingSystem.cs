using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public interface IAccountingSystem
    {
        void RecordIssuedBook(Book book, Reader reader);
        void RecordReturnedBook(Book book, Reader reader);
        void ShowTransactionHistory();
    }
    public class AccountingSystem : IAccountingSystem
    {
        private List<string> transactionHistory = new List<string>();
        public void RecordIssuedBook(Book book, Reader reader)
        {
            string record = $"[{DateTime.Now}] Книга '{book.Title}' выдана читателю {reader.FirstName} {reader.LastName} (Читательский билет: {reader.LibraryCardNumber})";
            transactionHistory.Add(record);
            Console.WriteLine(record);
        }
        public void RecordReturnedBook(Book book, Reader reader)
        {
            string record = $"[{DateTime.Now}] Книга '{book.Title}' возвращена читателем {reader.FirstName} {reader.LastName} (Читательский билет: {reader.LibraryCardNumber})";
            transactionHistory.Add(record);
            Console.WriteLine(record);
        }
        public void ShowTransactionHistory()
        {
            Console.WriteLine("\nИстория транзакций:");
            foreach (var record in transactionHistory)
            {
                Console.WriteLine(record);
            }
        }
    }
}
