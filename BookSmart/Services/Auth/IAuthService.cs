using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSmart.Models;

namespace BookSmart.Services.Auth
{
    public interface IAuthService
    {
        Task<User?> LoginAsync(string username, string password);
        Task<bool> RegisterAsync(string username, string password, string role);
    }
}
