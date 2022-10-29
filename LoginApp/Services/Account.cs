using Services.Helpers;
using Services.Helpers.Constants;
using System;

namespace Services {
    public class Account : IAccount{
        public string CheckLogin(int role, string email, string password)
        {
            if (email == AccountConstant.Email && password == AccountConstant.Password)
            {
                if (CheckRoles(role))
                {
                    return AccountConstant.Success;
                }
                else
                {
                    return AccountConstant.NoAuthorize;
                }
            }
            else
            {
                return AccountConstant.Failed;
            }
        }

        public bool CheckRoles(int role)
        {
            if (role == (int)Roles.SuperAdmin)
            {
                return true;

            }

            return false;
        }
        
    }
}
