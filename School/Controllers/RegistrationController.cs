﻿using Antlr.Runtime.Misc;
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
            else {
                
                _context.Users.InsertOne(user);
                // Cookies 

                UserCookie userCookie = new UserCookie();
                userCookie.FirstName = user.FirstName;
                userCookie.LastName = user.LastName;
                userCookie.Role = user.Role;

                SetCookie(userCookie);
                CheckCookie();


                return Content("1");

                


            }

            


        }

        

        public void SetCookie(UserCookie userCookie)
        {
            HttpCookie c = new HttpCookie("Imane");
            c["FirstName"] = userCookie.FirstName;
            c["LastName"] = userCookie.LastName;
            c["Role"] = userCookie.Role.ToString();
         
            c.Expires = DateTime.Now.AddDays(1);
            Response.Cookies.Add(c);

        }

        public void CheckCookie()
        {
            if (Request.Cookies["Imane"] != null)
            {
                //autologin 

            }
        }

    }
}
    