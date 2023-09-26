using MongoDB.Driver;
using School.Models;
using System.Configuration; // For traditional ASP.NET

public class MongoDbContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext()
    {
        var connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString; // For traditional ASP.NET
        // var connectionString = configuration.GetConnectionString("MongoDB"); // For ASP.NET Core

        var client = new MongoClient(connectionString);
        _database = client.GetDatabase("school");
    }
    public IMongoCollection<User> Users => _database.GetCollection<User>("User");
    public IMongoCollection<Student> Students => _database.GetCollection<Student>("students");
    public IMongoCollection<Teacher> Teachers => _database.GetCollection<Teacher>("teachers");
}
