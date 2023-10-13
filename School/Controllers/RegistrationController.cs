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
            
            if ( user.ValidateFirstName() )
            {
                _context.Users.InsertOne(user);
                return Content("Registration successful");

            }
            
            return Content("-1");



        }



    }
}
    