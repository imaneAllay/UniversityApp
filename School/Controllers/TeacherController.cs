using School.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.Controllers
{
    public class TeacherController : Controller
    {
        public ActionResult TeacherD()
        {

            var model = new Teacher
            {
                TeacherName = "John Doe",
                Role = "Math Teacher",
                ProgramNumber = "PN5678",
                Students = GetStudents(),
                Schedule = GetSchedule()
            };
            return View("TeacherD", model);
        }


        private List<Student> GetStudents() => new List<Student> { /*...*/ };
        private List<ScheduleItem> GetSchedule() => new List<ScheduleItem> { /*...*/ };
    }
}
