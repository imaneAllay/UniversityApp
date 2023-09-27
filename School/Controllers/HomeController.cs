using School.Models;

namespace School.Controllers
{
    public class HomeController : Controller
    {
        private readonly MongoDbContext dbContext = new MongoDbContext();

        public ActionResult Index()
        {
            return View();
        }




        public ActionResult CreateUser()
        {
            try
            {
                // Create a test user document
                var testUser = new User
                {
                    Username = "TestUser",
                    Password = "Password123", // Note: Password hashing should be used in a real application.
                    Email = "testuser@example.com",
                    Roles = new string[] { "User" } // You can set roles as needed.
                };

                // Insert the test user into the "User" collection
                var usersCollection = dbContext.Users;
                usersCollection.InsertOne(testUser);

                // Log a success message
                System.Diagnostics.Debug.WriteLine("Test user inserted successfully!");

                return Content("Test user inserted successfully!"); // Return a message to the user
            }
            catch (Exception ex)
            {
                // Log and handle any exceptions
                //System.Diagnostics.Debug.WriteLine($"Error inserting test user: {ex.Message}");
                //return Content($"Error inserting test user: {ex.Message}");
                return View();
            }
        }
        public ActionResult CreateStudent()
        {
            try
            {
                // Create a test student document
                var testStudent = new Student
                {
                    FirstName = "Test",
                    LastName = "Student",
                    EnrollmentDate = DateTime.Now
                    // Add other properties as needed
                };

                // Insert the test student into the "students" collection
                var studentsCollection = dbContext.Students;
                studentsCollection.InsertOne(testStudent);

                // Log a success message
                System.Diagnostics.Debug.WriteLine("Test student inserted successfully!");

                return Content("Test student inserted successfully!"); // Return a message to the user
            }
            catch (Exception ex)
            {
                // Log and handle any exceptions
                System.Diagnostics.Debug.WriteLine($"Error inserting test student: {ex.Message}");
                return Content($"Error inserting test student: {ex.Message}");
            }


            //public ActionResult SignUp()
            //{
            //    return View();
            //}

            //[HttpPost]
            //public ActionResult SignUp(User user)
            //{
            //    if (ModelState.IsValid)
            //    {
            //        context.Users.Add(user);
            //        context.SaveChanges();
            //        return RedirectToAction("Index");
            //    }
            //    return View(user);
            //}



        }
    }
}

