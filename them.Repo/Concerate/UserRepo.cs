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

        public bool deleteuser(int userid)
        {
           var v = ntireCrudContext.Users.SingleOrDefault(y=>y.Id == userid);
           ntireCrudContext.Users.Remove(v);
            return ntireCrudContext.SaveChanges() > 0 ? true : false;
        }

        public User getuser(int uid)
        {
             
            return ntireCrudContext.Users.Find(uid);
        }

        public List<User> getusers()
        {
            return ntireCrudContext.Users.ToList();
        }

        

        //public bool updateuser(User user)
        //{
        //    var v = ntireCrudContext.Users.SingleOrDefault(x=>x.Id == user.Id);
        //    v.Name = user.Name;
        //    v.Address1 = user.Address1;
        //    v.Address2 = user.Address2;
        //    v.City = user.City;
        //    v.Password = user.Password;
        //    return ntireCrudContext.SaveChanges() > 0 ? true : false;
        //}
    }
}
