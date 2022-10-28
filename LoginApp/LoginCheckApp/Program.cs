using Services;
using System;

namespace LoginCheckApp {
    class Program {
        static void Main(string[] args)
        {
            Account user = new Account();
            user.CheckLogin(1,"test@coder.edu.az","test12345");
            

        }
    }
}
