using Domain;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Infrastructure
{

    public class DatabaseSettings
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public class BaseContext<TEntity> where TEntity : Entity
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<TEntity> _collection;

        public BaseContext(DatabaseSettings settings)
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase(settings.DatabaseName);
            _collection = _database.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public IMongoCollection<TEntity> Collection => _collection;
    }
}