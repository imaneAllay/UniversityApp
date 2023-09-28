using MongoDB.Driver;
using School.Models;
using System.Configuration;

public class MongoDbContext
{
    private readonly IMongoDatabase _database;

    public MongoDbContext()
    {
        var connectionString = ConfigurationManager.ConnectionStrings["MongoDB"].ConnectionString; 
        

        var client = new MongoClient(connectionString);
        _database = client.GetDatabase("school");

        // Unique 
        var usersCollection = _database.GetCollection<User>("User");
        var usernameIndexModel = new CreateIndexModel<User>(Builders<User>.IndexKeys.Ascending(user => user.Username), new CreateIndexOptions
        {
            Unique = true
        });
        usersCollection.Indexes.CreateOne(usernameIndexModel);
    }
    public IMongoCollection<User> Users => _database.GetCollection<User>("User");

    public IMongoCollection<Student> Students => _database.GetCollection<Student>("students");
    public IMongoCollection<Teacher> Teachers => _database.GetCollection<Teacher>("teachers");
}
