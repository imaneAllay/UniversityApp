using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MongoDB.Driver;  

namespace School.Controllers
{
    public class HomeController : Controller
    {
        private readonly MongoDbContext dbContext = new MongoDbContext();

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(User user)
        {
            if (ModelState.IsValid)
            {
                var usersCollection = dbContext.Users;
                var foundUser = usersCollection.Find(u => u.Username == user.Username && u.Password == user.Password).SingleOrDefault();
                if (foundUser != null)
                {
                    return RedirectToAction("Dashboard");
                }
                else
                {
                    ModelState.AddModelError("", "Invalid login credentials.");
                }
            }
            return View(user);  
        }


        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp(User user)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var usersCollection = dbContext.Users;
                    usersCollection.InsertOne(user);

                    return RedirectToAction("Index");
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine($"Error inserting user: {ex.Message}");
                    ModelState.AddModelError("", "Error occurred while processing your request.");
                }
            }
            return View(user);  
    }
    public ActionResult Dashboard()
    {
        return View();
        }
    }

}

