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
       
        public ActionResult Register(User user, Contacts contactInfo, Teacher profile, Student profile2)
        {
            if (ModelState.IsValid)
            {
                string salt = BCrypt.Net.BCrypt.GenerateSalt(12);
                user.Salt = salt;
                user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password, salt);

                _context.Users.InsertOne(user);

                var userId = user.Id;

                contactInfo.UserId = userId;
                contactInfo.Email = user.Email;
                _context.Contacts.InsertOne(contactInfo);

                if (user.Role == UserRole.Teacher)
                {
                    profile.UserId = userId;
                    _context.Teachers.InsertOne(profile);
                }
                else if (user.Role == UserRole.Student)
                {
                    profile2.UserId = userId;
                    _context.Students.InsertOne(profile2);
                }

                return Json(new { success = true, message = "Registration successful" });
            }
            else
            {
                return Json(new { success = false, message = "Validation failed" });
            }
        }

        //    [HttpPost]
        //    public ActionResult Register(User user, Teacher profile, Student profile2, Contacts contactInfo)
        //    {
        //        if (ModelState.IsValid)
        //        {

        //            string salt = BCrypt.Net.BCrypt.GenerateSalt(12);
        //            user.Salt = salt;
        //            user.Password = BCrypt.Net.BCrypt.HashPassword(user.Password, salt);

        //            _context.Users.InsertOne(user);


        //            var userId = user.Id;

        //            contactInfo.UserId = userId;
        //            contactInfo.Email = user.Email;


        //            _context.Contacts.InsertOne(contactInfo);

        //            if (user.Role == UserRole.Teacher)
        //            {
        //                profile.UserId = userId;
        //                _context.Teachers.InsertOne(profile);
        //            }
        //            else if (user.Role == UserRole.Student)
        //            {
        //                profile2.UserId = userId;
        //                _context.Students.InsertOne(profile2);
        //            }


        //            return RedirectToAction("Login");

        //        }


        //        return View(user);

        //    }
        //}





    }
}
    