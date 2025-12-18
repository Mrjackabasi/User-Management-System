using System;
using System.Collections.Generic;
using System.Text;

namespace User_Managment_System
{
    public class AdminUser : User
    {
       

        public int PremissionLevel { get; set; }
        public AdminUser(int id, string? fullName, string? email,int premissionLevel) : base(id, fullName, email)
        {
            PremissionLevel = premissionLevel;
        }
        public void ManageUsers()
        {
            Console.WriteLine($"{FullName}Manageing Users .");
        }
        public override string GetUserInfo()
        {
            return $"[ADMIN] {FullName} | EMAIL{Email}| PremissonLevel {PremissionLevel}";
        }



    }



}




