﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

public class Student
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string FirstName { get; set; } 
    public string LastName { get; set; }
    public DateTime EnrollmentDate { get; set; }
}

