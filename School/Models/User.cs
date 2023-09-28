
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace School.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        Teacher,
        Student
    }
}