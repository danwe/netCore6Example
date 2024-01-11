using Microsoft.AspNetCore.Mvc;
using projectApiCore.Models;

namespace projectApiCore.Interfaces
{ 

    public interface IUserRepository
    {
        List<User> GetUsers();
    }
}
