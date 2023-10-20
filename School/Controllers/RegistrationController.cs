using Antlr.Runtime.Misc;
using MongoDB.Driver;
using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Web.Mvc;
using BCrypt.Net;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Web.Security;

namespace School.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly MongoDbContext _context;

        public RegistrationController()
        {
            _context = new MongoDbContext();
        }

        [HttpGet]
        public ActionResult Register()


        {
            return View();
        }

        [HttpPost]
        public ActionResult Register(User user)
        {
            // if (!user.ValidateUsername())
            //{
            //    return Content("us");
            //}
            //else if (!user.ValidatePassword())
            //{
            //    return Content("password");
            //}
            //else if (!user.ValidateConfirmPassword())
            //{
            //    return Content("confirmpassword");
            //}
            //else if (!user.ValidateEmail())
            //{
            //    return Content("email");
            //}
            //else if (!user.ValidatePhoneNumber())
            //{
            //    return Content("phone");
            //}
            //else if (!user.ValidateFirstName() )
            //{
            //    return Content("fn");

            //}
            if (!user.ValidateLastName())
            {
                return Content("ln");
            }

            else if (user.ValidateRole())
            {
                return Content("r");
            }

            //else if (user.DateOfBirth == DateTime.MinValue)
            //{
            //    return Content("DOB");
            //}
            //else if (user.DateOfBirth > DateTime.Now)
            //{
            //    return Content("DOBF");
            //}
            //var currentYear = DateTime.Now.Year;
            //var Age = currentYear - DateTime.Now.Year;

            // if (Age < 18)
            //{
            //    return Content("DOBA");
            //}

            //else if (user.DateOfBirth > DateTime.Now)
            //{
            //    return Content("DOBF");
            //}

            //else if (!user.ValidateDeparment())
            //{
            //    return Content("department");
            //}
            //else if (user.EnrollmentDate == DateTime.MinValue)
            //{
            //    return Content("en");
            //}
            else
            {


                _context.Users.InsertOne(user);
               
                UserCookie userCookie = new UserCookie()
                {
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Role = user.Role
                };

                SetCookie(userCookie);
               
                return Content("1");

            }
        }
            // conver a model to Json - save to cookie
            // one single string and assign it to the value
            // Encrypt the string - save it to cookie
            // Decrypt the cookie value = json string - convert again to the model

            public void SetCookie(UserCookie userCookie)
        {
           
            var jsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(userCookie);
            HttpCookie c = new HttpCookie("Imane");
            c.Value = jsonStr;
            c.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(c);

        }

       




    }
}
    