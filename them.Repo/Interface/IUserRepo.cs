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
    }
}
