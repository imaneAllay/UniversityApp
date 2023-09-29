using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace School.Models
{

    public class Teacher
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public string UserId { get; set; }
        public string StartDate { get; set; }
        public string Subjects { get; set; }
        public string NameOfSchool { get; set; }


    }
}
