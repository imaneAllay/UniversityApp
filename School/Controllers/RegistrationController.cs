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
        public ActionResult Register( User user)
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
            //else if (!user.ValidateLastName())
            //{
            //    return Content("ln");
            //}
          
            if (user.DateOfBirth == DateTime.MinValue)
            {
                return Content("DOB");
            }
            else if (user.DateOfBirth > DateTime.Now)
            {
                return Content("DOBF");
            }
            var currentYear = DateTime.Now.Year;
            var currentMonth = DateTime.Now.Month;
            var currentDay = DateTime.Now.Day;
            var minAge = new DateTime (currentYear - 18 , currentMonth , currentDay);

             if (user.DateOfBirth > minAge)
            {
                return Content("DOBA");
            }








            else if (user.DateOfBirth > DateTime.Now)
            {
                return Content("DOBF");
            }

            //else if (!user.ValidateDeparment())
            //{
            //    return Content("department");
            //}
            //else if (user.EnrollmentDate == DateTime.MinValue)
            //{
            //    return Content("en");
            //}
            else {
                
                _context.Users.InsertOne(user);
                return Content("1");
            }

            

        }



    }
}
    