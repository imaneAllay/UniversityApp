﻿
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
        public string Id { get; set; }
        [Required(ErrorMessage = "Username is required")]
       
        public string Username { get; set; }
        [Required(ErrorMessage = "Password is required")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public UserRole Role { get; set; }
    }

    public enum UserRole
    {
        Teacher,
        Student
    }
}