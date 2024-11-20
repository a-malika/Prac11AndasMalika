using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
        protected User(int id, string name, string email, string userType)
        {
            Id = id;
            Name = name;
            Email = email;
            UserType = userType;
        }
    }
}
