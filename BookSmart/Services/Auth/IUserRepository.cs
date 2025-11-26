using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSmart.Models;

namespace BookSmart.Services.Auth
{
    public interface IUserRepository
    {
        Task<List<User>> LoadUsersAsync();
        Task SaveUsersAsync(List<User> users);
    }
}
