using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using them.BussinessEntity;
using them.Database;

namespace them.BussinessService.Interface
{
    public interface IUserService
    {
        bool adduser(UserViewModel userViewModel);

        UserViewModel getuser(int uid);

        bool deleteuser(int userid);

        List<UserViewModel> getusers();
    }
}
