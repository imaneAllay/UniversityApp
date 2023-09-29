using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace School.Models
{

    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public DateTime EnrollmentDate { get; set; }
        public string classes { get; set; }
        public string grade { get; set; }
    }
}
