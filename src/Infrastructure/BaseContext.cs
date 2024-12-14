using Domain;
using MongoDB.Driver;

namespace Infrastructure
{
    public class BaseContext<TEntity> where TEntity : Entity
    {
        private readonly IMongoDatabase _database;
        private readonly IMongoCollection<TEntity> _collection;

        public BaseContext()
        {
            var client = new MongoClient("mongodb://localhost:27017");
            _database = client.GetDatabase("test");
            _collection = _database.GetCollection<TEntity>(typeof(TEntity).Name);
        }

        public IMongoCollection<TEntity> Collection => _collection;
    }
}