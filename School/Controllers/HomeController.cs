using MongoDB.Driver;
using School.Models;
using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        private readonly MongoDbContext dbContext = new MongoDbContext();
        private IEnumerable<Student> studentsToInsert;

        public ActionResult Login()
        {
            var user = new User();
            return View("Login");
        }

        [HttpPost]
        public ActionResult Login(User user)
        {
            if (ModelState.IsValid)
            {

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
                else
                {
                    ModelState.AddModelError("", "Invalid username or password");
                }
            }


            return View();
        }

        //public ActionResult CreateUsers()
        //{

        //    try
        //    {

        //        var userToInsert = new List<User>
        //    {
        //        new User
        //        {
        //                Username = "imane",
        //                Password = "123",
        //                Role= UserRole.Teacher

        //        },
        //        new User
        //        {
        //            Username = "karina",
        //             Password = "1234",
        //             Role= UserRole.Teacher

        //        },


        //    };


        //        var usersCollection = dbContext.Users;
        //        usersCollection.InsertMany(userToInsert);

        //        System.Diagnostics.Debug.WriteLine("Users inserted successfully!");

        //        return Content("Users inserted successfully!");
        //        //return View();
        //    }
        //    catch (Exception ex)
        //    {
        //        System.Diagnostics.Debug.WriteLine($"Error inserting Users: {ex.Message}");
        //        return Content($"Error inserting Users: {ex.Message}");

        //    }

        //}





    }
}

