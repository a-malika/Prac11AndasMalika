using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice11
{
    public class UserManager
    {
        public Library Library { get; set; }
        public UserManager(Library library)
        {
            Library = library;
        }
        public void RegisterUser(User user)
        {
            Library.UserList.Add(user);
        }
        public void UnregisterUser(int id)
        {
            Library.UserList.RemoveAll(u => u.Id == id);
        }
    }
}
