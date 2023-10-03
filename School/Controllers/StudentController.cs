using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using School.Models; 

namespace School.Controllers
{
    public class StudentController : Controller
    {
       
        public ActionResult StudentD()
        {
            var student = new Student
            {
                
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
                    }
                },
                Assignments = new List<Assignment>
                {
                    new Assignment
                    {
                        Title = "Assignment 1",
                        Status = "Incomplete"
                    },
                   
                }
               
            };

            return View(student);
        }
    }
}