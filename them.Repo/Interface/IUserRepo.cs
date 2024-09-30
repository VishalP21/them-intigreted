using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using them.Database;

namespace them.Repo.Interface
{
    public interface IUserRepo
    {
        bool adduser(User user); 

        User getuser(int uid);

        bool deleteuser(int userid);

        List<User> getusers();
    }
}
