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
            
            if (!user.ValidateFirstName() )
            {
                return Content("fn");

            }
            else if (!user.ValidateLastName())
            {
                return Content("ln");
            }
            else if (!user.ValidateUsername())
            {
                return Content("us");
            }
            else if (!user.ValidateEmail())
            {
                return Content("email");
            }
            else if (!user.ValidatePassword())
            {
                return Content("password");
            }
            else if (!user.ValidateConfirmPassword())
            {
                return Content("confirmpassword");
            }
            else if (!user.ValidatePhoneNumber())
            {
                return Content("phone");
            }
            else if (string.IsNullOrWhiteSpace(user.DateOfBirth))
                {
                return Content("DOB");
            }
            
            else if (!user.ValidateDeparment())
            {
                return Content("department");
            }
            else if (string.IsNullOrWhiteSpace(user.EnrollmentDate))
            {
                return Content("en");
            }
            else {
                
                _context.Users.InsertOne(user);
                return Content("1");
            }

            

        }



    }
}
    