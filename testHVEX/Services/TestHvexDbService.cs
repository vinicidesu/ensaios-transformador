using Microsoft.Extensions.Options;
using MongoDB.Driver;
using testHVEX.Models;

namespace testHVEX.Services
{
    public class TestHvexDbService
    {
        private readonly IMongoCollection<User> _userCollection;

        public TestHvexDbService(IOptions<TestHvexDbSettings> testHvexDbSettings)
        {
            MongoClient client = new MongoClient(testHvexDbSettings.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(testHvexDbSettings.Value.DatabaseName);
            _userCollection = database.GetCollection<User>(testHvexDbSettings.Value.CollectionName);
        }
    }
}
