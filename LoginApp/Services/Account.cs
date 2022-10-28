using Services.Helpers;
using System;

namespace Services {
    public class Account : IAccount{
        public void CheckLogin(int role,string username, string passcode)
        {
            if (username == "test@code.edu.az" && passcode == "test12345")
            {
                CheckRoles(role);
            }
            else
            {
                if (username != "test@code.edu.az" || passcode != "test12345")
                {
                    Console.WriteLine("Oops something went wrong. Please double check your email or password ");
                }
            }
        }

        public void CheckRoles(int role)
        {
            switch (role)
            {
                case (int)Roles.SuperAdmin:
                    Console.WriteLine("Your Status is SuperAdmin and You are Successfully login in");
                    break;
                case (int)Roles.Admin:
                    Console.WriteLine("Your Status is Admin, Access DENIED");
                    break;
                case (int)Roles.Member:
                    Console.WriteLine("Your Status is Member, Access DENIED ");
                    break;
                default:
                    Console.WriteLine("You HAVE NOT access to login this website") ;
                    break;
            }
        }
    }
}
