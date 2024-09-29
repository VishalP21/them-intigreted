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
    }
}
