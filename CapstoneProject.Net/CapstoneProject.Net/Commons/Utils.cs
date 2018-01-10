using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CapstoneProject.Net.Commons
{
    public static class Utils
    {
        public static bool IsDigitsOnly(string str)
        {
            if (String.IsNullOrEmpty(str))
            {
                return false;
            }
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }
    }
}