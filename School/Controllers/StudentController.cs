using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.Models;  // Ensure this using directive is present to access Student model

namespace School.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentD()
        {
            var student = new Student
            {
                // Populate student properties here, for example:
                FirstName = "John",
                LastName = "Doe",
                EnrollmentDate = DateTime.Now,
                Role = "Student",
                Schedule = new List<ScheduleItem>
                {
                    new ScheduleItem
                    {
                        Day = "Monday",
                        Time = "9:00 AM",
                        Subject = new Subject { Name = "Math" }
                    },
                    // ... other schedule items
                },
                Assignments = new List<Assignment>
                {
                    new Assignment
                    {
                        Title = "Assignment 1",
                        Status = "Incomplete"
                    },
                    // ... other assignments
                }
                // ... other properties
            };

            return View(student);
        }
    }
}
