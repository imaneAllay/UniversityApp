using Amazon.Runtime.Internal;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Security;

namespace School.Utils
{
    public static class Utils
    {
        private static string publicKey = System.Configuration.ConfigurationManager.AppSettings["PublicKey"];

        public static string Encrypt(UserCookie userCookie)
        {
            var jsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(userCookie);
            var cookieContent = Encoding.UTF8.GetBytes(jsonStr);
            var encryptedValue = Convert.ToBase64String(MachineKey.Protect(cookieContent, publicKey));
            return encryptedValue;
        }

        public static UserCookie Decrypt(string getCookie)
        {
            var cookie = Convert.FromBase64String(getCookie);
            var output = MachineKey.Unprotect(cookie, publicKey);
            var result = Encoding.UTF8.GetString(output);
            return  Newtonsoft.Json.JsonConvert.DeserializeObject<UserCookie>(result);
          
      

        }
    }
}