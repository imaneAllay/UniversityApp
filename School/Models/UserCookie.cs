using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Models
{
    public class UserCookie
    {
        public string FirstName {  get; set; }  
        public string LastName { get; set; }
        public UserRole Role { get; set; }
    }
    
}