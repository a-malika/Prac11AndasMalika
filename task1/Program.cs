using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var library = new Library();

            var bookManager = new BookManager(library);
            var userManager = new UserManager(library);
            var loanManager = new LoanManager(library);
            var reportManager = new ReportManager(library);

            var author1 = new Author("Джордж Оруэлл");
            var author2 = new Author("Фёдор Достоевский");
            var book1 = new Book(1, "1984", "9780451524935", new List<Author> { author1 }, 1949);
            var book2 = new Book(2, "Преступление и наказание", "9780140449136", new List<Author> { author2 }, 1866);
            bookManager.AddBook(book1);
            bookManager.AddBook(book2);
            
            var reader1 = new Reader(1, "Иван Иванов", "ivan@gmail.com", "Reader");
            var reader2 = new Reader(2, "Попов Александр Степаныч", "physicIsLive@gmail.com", "Reader");
            var librarian = new Librarian(3, "Анна Смирнова", "anna@mail.ru", "Librarian", "Главный библиотекарь");
            userManager.RegisterUser(reader1);
            userManager.RegisterUser(reader2);
            userManager.RegisterUser(librarian);

            loanManager.IssueLoan(book1, reader1);
            loanManager.IssueLoan(book2, reader2);
            loanManager.CompleteLoan(book1, reader1);

            var report = reportManager.CreateReport("Ежедневный");

            Console.WriteLine("Список книг:");
            foreach (var book in library.BookList)
            {
                Console.WriteLine(book.GetBookInfo());
            }

            Console.WriteLine("\nПользователи библиотеки:");
            foreach (var user in library.UserList)
            {
                Console.WriteLine($"ID: {user.Id}, Имя: {user.Name}, Email: {user.Email}, Тип: {user.UserType}");
            }

            Console.WriteLine("\nСписок займов:");
            foreach (var loan in library.LoanList)
            {
                var returnDate = loan.ReturnDate != DateTime.MinValue ? $"{loan.ReturnDate}" : "отсутствует";
                Console.WriteLine($"Книга: {loan.Book.Title}, Читатель: {loan.Reader.Name}, Дата выдачи: {loan.LoanDate}, Дата возврата: {loan.ReturnDate}");
            }

            Console.WriteLine($"\nОтчёт: {report}");
        }
    }
}
