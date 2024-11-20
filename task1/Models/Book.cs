using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public List<Author> Author { get; set; }
        public int PublicationYear { get; set; }
        public bool AvailabilityStatus { get; set; }
        public Book(int id, string title, string isbn, List<Author> authors, int publicationYear)
        {
            Id = id;
            Title = title;
            ISBN = isbn;
            Author = authors;
            PublicationYear = publicationYear;
            AvailabilityStatus = true;
        }
        public void ChangeAvailabilityStatus(bool status)
        {
            AvailabilityStatus = status;
        }
        public string GetBookInfo()
        {
            return $"{Title} ({PublicationYear}), ISBN: {ISBN}";
        }
    }
}
