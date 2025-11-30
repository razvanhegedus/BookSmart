using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookSmart.Models;
using BookSmart.Services.Utility;

namespace BookSmart.Services.Auth
{
    public class AuthService : IAuthService
    {
        private readonly IUserRepository _userRepository;

        public AuthService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<User?> LoginAsync(string username, string password)
        {
            var users = await _userRepository.LoadUsersAsync();
            string hash = PasswordHasher.Hash(password);

            return users.FirstOrDefault(u =>
                u.Username == username && u.PasswordHash == hash);
        }

        public async Task<bool> RegisterAsync(string username, string password, string role)
        {
            var users = await _userRepository.LoadUsersAsync();

            if (users.Any(u => u.Username == username))
                return false; // username taken

            string hash = PasswordHasher.Hash(password);
            users.Add(new User(username, hash, role));

            await _userRepository.SaveUsersAsync(users);
            return true;
        }
    }
}
