﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }
        public string ISBN { get; set; }
        public Book(string title, string author, string genre, string isbn)
        {
            Title = title;
            Author = author;
            Genre = genre;
            ISBN = isbn;
        }
    }
}
