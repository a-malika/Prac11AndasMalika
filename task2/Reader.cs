using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class Reader
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string LibraryCardNumber { get; set; }
        public Reader(string firstName, string lastName, string libraryCardNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            LibraryCardNumber = libraryCardNumber;
        }
    }
}
