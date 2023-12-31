﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace School.Models
{
    public class Contacts
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public ObjectId Id { get; set; }
        public ObjectId UserId { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AlternateNumber { get; set; }

    }
}