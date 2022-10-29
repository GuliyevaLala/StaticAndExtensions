using System;
using System.Collections.Generic;
using System.Text;

namespace Services {
    public interface IAccount {
        public string CheckLogin (int role, string email, string password);

    }
}
 