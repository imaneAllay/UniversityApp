using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace School.Models
{

    public class Teacher
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]

        public ObjectId Id { get; set; }
        public ObjectId UserId { get; set; }
        public string TeacherName { get; set; }
        public string Role { get; set; }
        public string ProgramNumber { get; set; }



        public List<Student> Students { get; set; }
        public List<ScheduleItem> Schedule { get; set; }

    }




}