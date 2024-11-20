using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class Reader : User
    {
        public List<Loan> BorrowedBooks { get; set; }
        public Reader(int id, string name, string email, string userType) : base(id, name, email, userType)
        {
            BorrowedBooks = new List<Loan>();
        }
    }
}
