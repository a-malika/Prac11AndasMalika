using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class Librarian : User
    {
        public string Position { get; set; }
        public Librarian(int id, string name, string email, string userType, string position) : base(id, name, email, userType)
        {
            Position = position;
        }
    }
}
