using OnlinePCShop.Models;
using System.Collections.Generic;
using System.Linq;

namespace OnlinePCShop.Services
{
    public class AuthService
    {
        private List<User> users = new List<User>();
        private List<Admin> admins = new List<Admin>();
        private int nextUserId = 1;
        private int nextAdminId = 1;

        public User CurrentUser { get; private set; }
        public Admin CurrentAdmin { get; private set; }

        // Thêm tài khoản admin mặc định
        public AuthService()
        {
            admins.Add(new Admin
            {
                AdminId = nextAdminId++,
                Name = "admin",
                Email = "admin@admin.com",
                Password = "12345"
            });
        }

        public bool Register(User newUser)
        {
            if (users.Any(u => u.Email == newUser.Email))
            {
                return false; // Email đã tồn tại
            }
            newUser.UserId = nextUserId++;
            users.Add(newUser);
            return true;
        }

        public bool Login(string email, string password)
        {
            var user = users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                CurrentUser = user;
                return true;
            }
            return false;
        }

        public bool AdminLogin(string email, string password)
        {
            var admin = admins.FirstOrDefault(a => a.Email == email && a.Password == password);
            if (admin != null)
            {
                CurrentAdmin = admin;
                return true;
            }
            return false;
        }

        public void Logout()
        {
            CurrentUser = null;
            CurrentAdmin = null;
        }

        public bool IsLoggedIn()
        {
            return CurrentUser != null || CurrentAdmin != null;
        }

        public bool IsAdmin()
        {
            return CurrentAdmin != null;
        }

        public List<User> GetUsers()
        {
            return users;
        }
    }

    public class Admin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
