using Services;
using System;

namespace LoginCheckApp {
    class Program {
        static void Main(string[] args)
        {
            
            Login();
        }
        public static void Login()
        {
            Console.WriteLine("Please enter your email : ");
            string email = Console.ReadLine();
            Console.WriteLine("Please enter your password : ");
            string password = Console.ReadLine();
            int role = 2;

            Account account = new Account();
            Console.WriteLine(account.CheckLogin(role, email, password));
        }
    }
}
