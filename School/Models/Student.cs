using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace School.Models
{

    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public int Id { get; set; }
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        public string Role { get; set; }
        public string classes { get; set; }
        public string grade { get; set; }

        public List<ScheduleItem> Schedule { get; set; }

        public List<Assignment> Assignments { get; set; }
    }
}