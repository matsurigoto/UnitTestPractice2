using System;
using System.Collections.Generic;
using System.Text;

namespace AuthenticationService
{
    public static class Context
    {
        public static Dictionary<string, string> profiles;

        static Context()
        {
            profiles = new Dictionary<string, string>();
            profiles.Add("Duran", "12");
            profiles.Add("Ina", "13");
        }

        public static string GetPassword(string key)
        {
            return profiles[key];
        }
    }
}
