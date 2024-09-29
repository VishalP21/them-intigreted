using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using them.Database;
using them.Repo.Interface;

namespace them.Repo.Concerate
{
    public class UserRepo : IUserRepo
    {
        private readonly NtireCrudContext ntireCrudContext;
        public UserRepo()
        {
            ntireCrudContext = new NtireCrudContext();
        }
        public bool adduser(User user)
        {
            ntireCrudContext.Users.Add(user);
            return ntireCrudContext.SaveChanges()>0?true:false;
        }
    }
}
