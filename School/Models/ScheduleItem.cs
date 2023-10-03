using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace School.Models
{
    public class ScheduleItem
    {
        public string Day { get; set; }
        public string Time { get; set; }

        public Subject Subject { get; set; }
    }
}