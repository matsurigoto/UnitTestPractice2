using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationService
{
    public class ProfileDao
    {
        public string GetPassword(string account)
        {
            return Context.GetPassword(account);
        }
    }
}
