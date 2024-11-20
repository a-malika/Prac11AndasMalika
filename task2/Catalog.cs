using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public interface ICatalog
    {
        void AddBook(Book book);
        List<Book> SearchByAuthor(string author);
        List<Book> SearchByGenre(string genre);
        Book? SearchByTitle(string title);
    }
    public class Catalog : ICatalog
    {
        private List<Book> books = new List<Book>();
        public void AddBook(Book book)
        {
            if (!books.Contains(book))
            {
                books.Add(book);
                Console.WriteLine($"Книга '{book.Title}' добавлена в каталог.");
            }
            else
            {
                Console.WriteLine($"Книга '{book.Title}' не может быть добавлена. Она уже содержится в каталоге.");
            }
        }
        public Book? SearchByTitle(string title) =>
            books.FirstOrDefault(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        public List<Book> SearchByAuthor(string author) =>
            books.Where(b => b.Author.Contains(author, StringComparison.OrdinalIgnoreCase)).ToList();
        public List<Book> SearchByGenre(string genre) =>
            books.Where(b => b.Genre.Contains(genre, StringComparison.OrdinalIgnoreCase)).ToList();
    }
}
