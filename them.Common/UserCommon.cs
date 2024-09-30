using System.Runtime.CompilerServices;
using them.BussinessEntity;
using them.Database;

namespace them.Common
{
    public static class UserCommon
    {
       public static User ToDataModel(this UserViewModel userViewModel)
        {
            User user = new User();
            user.Name = userViewModel.Name;
            user.Address1 = userViewModel.Address1;
            user.Address2 = userViewModel.Address2;
            user.City = userViewModel.City;
            user.Password = userViewModel.Password;
            return user;
        }

        public static UserViewModel ToDataModele(this User user)
        {
            UserViewModel userViewModel = new UserViewModel();
            userViewModel.Id = user.Id;
            userViewModel.Name = user.Name;
            userViewModel.Address1 = user.Address1;
            userViewModel.Address2 = user.Address2;
            userViewModel.City = user.City;
            return userViewModel;
        }

        public static UserViewModel ToViewModel(this User user)
        {
            UserViewModel userViewModel = new UserViewModel();
            userViewModel.Id = user.Id;
            userViewModel.Name = user.Name;
            userViewModel.Address1 = user.Address1;
            userViewModel.Address2 = user.Address2;
            userViewModel.City = user.City;
            return userViewModel;
        }

        public static List<UserViewModel> ToViewModel(this List<User> user)
        {
            return user.Select(x => x.ToViewModel()).ToList();
        }
    }
}
