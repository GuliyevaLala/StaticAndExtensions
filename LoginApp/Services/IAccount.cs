using System;
using System.Collections.Generic;
using System.Text;

namespace Services {
    public interface IAccount {
        public void CheckLogin (int role, string email, string password);
        public void CheckRoles(int role);

    }
}
 