using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System.ComponentModel;
using testHVEX.Models;

namespace testHVEX.Services
{
    public class TestHvexDbService
    {
        private readonly IMongoCollection<User> _userCollection;

        public TestHvexDbService(IOptions<HvexTestDbSettings> testHvexDbSettings)
        {
            MongoClient client = new MongoClient(testHvexDbSettings.Value.ConnectionString);
            IMongoDatabase database = client.GetDatabase(testHvexDbSettings.Value.DatabaseName);
            _userCollection = database.GetCollection<User>(testHvexDbSettings.Value.CollectionName);
        }

        public async Task CreateAsync(User user)
        {
            await _userCollection.InsertOneAsync(user);
            return;
        }

        public async Task<List<User>> GetAsync() 
        {
            return await _userCollection.Find(new BsonDocument()).ToListAsync();
        }

        public async Task AddToUserAsync(string id, string name) 
        {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("Id", id);
            UpdateDefinition<User> update = Builders<User>.Update.AddToSet<string>("name", name);
            await _userCollection.UpdateOneAsync(filter, update);
            return;
        }

        public async Task DeleteAsync(string id) 
        {
            FilterDefinition<User> filter = Builders<User>.Filter.Eq("Id", id);
            await _userCollection.DeleteOneAsync(filter);
            return;
        }
    }
}
