using System;
using System.Collections.Generic;
using System.Text;

namespace User_Managment_System
{
    public class User
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; }

        public User(int id, string? fullName, string? email)
        {
            Id = id;
            FullName = fullName;
            Email = email;
            IsActive = true;
        }
        public void Login()
        {
            Console.WriteLine($"{FullName}you are login");
        }
        public void Logout()
        {
            Console.WriteLine($"you are logout");
        }
        public virtual string GetUserInfo()
        {
            return $"User : {FullName} - Email : {Email}";
        }
    }
}
