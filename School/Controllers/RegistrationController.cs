
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


        public ActionResult Register(User user, Teacher profile, Student profile2, Contacts contactInfo)

        {

            //    string inputPassword = user.Password;
            //    string salt = BCrypt.Net.BCrypt.GenerateSalt(12);
            //    //string hashedPassword = BCrypt.Net.BCrypt.HashPassword(inputPassword, salt);


            //    if (ModelState.IsValid) 
            //    {
            //        _context.Users.InsertOne(user);
            //        var userId = user.Id;
            //        var email = user.Email;
            //        var password = hashedPassword;
            //        var Salt = salt;
            //        var role = user.Role;
            //        contactInfo.UserId = userId;
            //        contactInfo.Email = email;



            //        if (user.Role == UserRole.Teacher)
            //        {
            //            profile.UserId = userId;
            //            _context.Teachers.InsertOne(profile);
            //        }
            return View(user);

        }
            
}






      }
    
    
