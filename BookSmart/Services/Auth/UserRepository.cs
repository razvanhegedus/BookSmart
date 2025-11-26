using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using BookSmart.Models;
using BookSmart.Services.Utility;

namespace BookSmart.Services.Auth
{
    public class UserRepository : IUserRepository
    {
        private readonly string _usersPath;

        public UserRepository()
        {
            var projectRoot = Path.GetFullPath(
                Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\")
            );
            _usersPath = Path.Combine(projectRoot, "Data", "users.txt");

            EnsureFileAndDefaultAdmin();
        }

        private void EnsureFileAndDefaultAdmin()
        {
            var dir = Path.GetDirectoryName(_usersPath);
            if (!Directory.Exists(dir) && dir != null)
                Directory.CreateDirectory(dir);

            if (!File.Exists(_usersPath))
            {
                string adminHash = PasswordHasher.Hash("admin");
                File.WriteAllText(_usersPath, $"admin;{adminHash};admin{Environment.NewLine}");
            }
        }

        public async Task<List<User>> LoadUsersAsync()
        {
            var list = new List<User>();

            if (!File.Exists(_usersPath))
                return list;

            var lines = await File.ReadAllLinesAsync(_usersPath);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line) || line.StartsWith("#"))
                    continue;

                var parts = line.Split(';');
                if (parts.Length < 3) continue;

                list.Add(new User(parts[0], parts[1], parts[2]));
            }

            return list;
        }

        public async Task SaveUsersAsync(List<User> users)
        {
            var lines = users.Select(u => $"{u.Username};{u.PasswordHash};{u.Role}");
            await File.WriteAllLinesAsync(_usersPath, lines);
        }
    }
}
