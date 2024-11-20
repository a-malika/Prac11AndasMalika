using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class BookManager
    {
        public Library Library { get; set; }
        public BookManager(Library library)
        {
            Library = library;
        }
        public void AddBook(Book book)
        {
            Library.BookList.Add(book);
        }
        public void RemoveBook(int id)
        {
            Library.BookList.RemoveAll(b => b.Id == id);
        }
        public void ChangeBookInfo(int id, Book updatedBook)
        {
            var book = Library.BookList.Find(b => b.Id == id);
            if (book != null)
            {
                book.Title = updatedBook.Title;
                book.ISBN = updatedBook.ISBN;
                book.Author = updatedBook.Author;
                book.PublicationYear = updatedBook.PublicationYear;
            }
        }
        public List<Book> FindBookByTitle(string title)
        {
            return Library.BookList.FindAll(b => b.Title.Contains(title, StringComparison.OrdinalIgnoreCase));
        }
        public List<Book> FindBookByAuthor(string author)
        {
            return Library.BookList.FindAll(b => b.Author.Exists(a => a.Name.Contains(author, StringComparison.OrdinalIgnoreCase)));
        }
    }
}
