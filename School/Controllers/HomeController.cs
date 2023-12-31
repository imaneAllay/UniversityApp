﻿using MongoDB.Driver;
using School.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.UI.WebControls;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        private readonly MongoDbContext dbContext = new MongoDbContext();
        

        public ActionResult Login()
        {
            if (Request.Cookies["Imane"] != null)
            {
                // web config 
                // utils folder 
                // Encrypt/Decrypt functions 
                // URL encryption

                var getCookie = Request.Cookies["Imane"].Value;

                UserCookie userCookie = Utils.Utils.Decrypt(getCookie);
                if (userCookie.Role == UserRole.Teacher)
                {
                    return RedirectToAction("TeacherD", "Teacher");
                }
                else if (userCookie.Role == UserRole.Student)
                {
                    return RedirectToAction("StudentD", "Student");
                }
            }
            var user = new User();
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            Debug.WriteLine("Login action reached.");


            var filter = Builders<User>.Filter.Eq(u => u.Username, user.Username) &
                            Builders<User>.Filter.Eq(u => u.Password, user.Password);

            var authenticatedUser = dbContext.Users.Find(filter).FirstOrDefault();

            if (authenticatedUser != null)
            {
                var userRole = authenticatedUser.Role;
                UserCookie userCookie = new UserCookie()
                {
                    FirstName = authenticatedUser.FirstName,
                    LastName = authenticatedUser.LastName,
                    Role = authenticatedUser.Role
                };

               

                if (userRole == UserRole.Teacher)
                {
                    return RedirectToAction("TeacherD", "Teacher");
                }
                else if (userRole == UserRole.Student)
                {
                    return RedirectToAction("StudentD", "Student");
                }
                
            }

            Content("-1");
            return View("Login", user);
        }



        //public ActionResult CheckCookie()
        //{
        //    if (Request.Cookies["Imane"] != null)
        //    {
        //        var cookie = Request.Cookies["Imane"];
        //        var userCookie = Newtonsoft.Json.JsonConvert.DeserializeObject<UserCookie>(cookie.Value);

        //        if (userCookie.Role == UserRole.Teacher)
        //        {
        //            return RedirectToAction("TeacherD", "Teacher");
        //        }
        //        else if (userCookie.Role == UserRole.Student)
        //        {
        //            return RedirectToAction("StudentD", "Student");
        //        }
        //    }

        //    return View("Login");
        //}

       

      
    }



}
 
