

using projectApiCore.Interfaces;
using projectApiCore.Models;
using System.Collections.Generic;
using System.Text.Json;

namespace projectApiCore.Repository
{
    public class UserRepository : IUserRepository
    {



        public List<Root> GetUsers()
        {

            var json = File.ReadAllText(@"c:\dev\root.json");
            //  Root root = JsonSerializer.Deserialize<Root>(json);
            List<Root> root = new List<Root>();
            using (StreamReader r = new StreamReader(@"c:\dev\root.json"))
            {
                string jsona = r.ReadToEnd();
                root = JsonSerializer.Deserialize<List<Root>>(jsona);
            }
            return root;
        }

       


      


       
    }
}