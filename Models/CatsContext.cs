using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using MongoDB.Driver;


namespace myFirstProject.Models
{
    public class CatsContext
    {
        private readonly IMongoDatabase _database = null;
        public CatsContext(IOptions<Settings> settings)
        {
            // connect to mongoDB server
            var client = new MongoClient(settings.Value.ConnectionString);
            if (client != null) // if server connected, connect with database
                _database = client.GetDatabase(settings.Value.Database);
        }

        public IMongoCollection<Cat> Cats
        {
            get
            {
                return _database.GetCollection<Cat>("Cat"); // get collection (Cat)
            }
        }
    }
}
