using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using them.BussinessEntity;
using them.BussinessService.Interface;
using them.Repo.Concerate;
using them.Common;

namespace them.BussinessService.Concreate
{
    public class UserService : IUserService
    {
        private readonly UserRepo userRepo;

        public UserService()
        {
            userRepo = new UserRepo();
        }
        public bool adduser(UserViewModel userViewModel)
        {
            return userRepo.adduser(userViewModel.ToDataModel());
        }

        public bool deleteuser(int userid)
        {
            return userRepo.deleteuser(userid);
        }

        public UserViewModel getuser(int uid)
        {
            return userRepo.getuser(uid).ToDataModele();
        }

        public List<UserViewModel> getusers()
        {
            return userRepo.getusers().ToViewModel();
        }

        
    }
}
