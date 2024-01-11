

using projectApiCore.Interfaces;
using projectApiCore.Models;
using System.Collections.Generic;

namespace projectApiCore.Repository
{
    public class UserRepository : IUserRepository
    {



        public List<User> GetUsers()
        {
            List<User> list = new List<User>();
            User u1 = new User();
            u1.mail = "asdasda@gmail.com";
            u1.Name = "dan";
            u1.Id = 1;
            list.Add(u1);   

            return list;
        }

       


      


       
    }
}