using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using them.BussinessEntity;

namespace them.BussinessService.Interface
{
    public interface IUserService
    {
        bool adduser(UserViewModel userViewModel);
    }
}
