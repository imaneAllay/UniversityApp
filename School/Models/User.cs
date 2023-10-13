using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Driver;

namespace School.Models
{
    public class User
    {

        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string confirmPassword { get; set; }

        public string Salt { get; set; }

        public string Email { get; set; }
        public string PhoneNumber { get; set; }

        public string FirstName { get; set; }


        public string LastName { get; set; }

        public UserRole Role { get; set; }

        public DateTime DateOfBirth { get; set; }


        public string Department { get; set; }


        public DateTime EnrollmentDate { get; set; }

        public bool ValidateFirstName()
        {
            return !string.IsNullOrEmpty(FirstName) && FirstName.Length >= 3;
        }

    }
    public enum UserRole
    {
        Teacher,
        Student
    }


}


