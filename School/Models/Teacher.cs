using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

public class Teacher
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string Id { get; set; }

    public string Username { get; set; }
    public string Password { get; set; }
    public string[] Roles { get; set; }
}
