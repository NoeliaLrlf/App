using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApi.Client
{
    class RestHeader
    {
        public static string GetPassword()
        {
            string password = ConfigurationManager.AppSettings["user"] + ":" + ConfigurationManager.AppSettings["password"];
            var plainTextBytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(plainTextBytes);
        }
    }
}
