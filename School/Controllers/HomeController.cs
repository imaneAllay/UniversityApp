using MongoDB.Driver;
using School.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        private readonly MongoDbContext dbContext = new MongoDbContext();
        

        public ActionResult Login()
        {
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







    }
}
