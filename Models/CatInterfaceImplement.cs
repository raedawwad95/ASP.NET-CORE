using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace myFirstProject.Models
{
    public class CatInterfaceImplement : CatInterface
    {
        private readonly CatsContext _context = null;

        public CatInterfaceImplement(IOptions<Settings> settings)
        {
            _context = new CatsContext(settings);
        }

        public async Task<IEnumerable<Cat>> GetAll()
        {
            try
            {
                return await _context.Cats
                        .Find(_ => true).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task insertCat(Cat item)
        {
            try
            {
                await _context.Cats.InsertOneAsync(item);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> RemoveCat(string name)
        {
            try
            {
                DeleteResult actionResult
                    = await _context.Cats.DeleteOneAsync(
                        Builders<Cat>.Filter.Eq("Name", name));

                return actionResult.IsAcknowledged
                    && actionResult.DeletedCount > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<bool> UpdateCat(string id, string name)
        {
            // convert string (id param) to object ID 
            var internalID = new BsonObjectId(new ObjectId(id));
            // use Object it to filter documents in database
            var filter = Builders<Cat>.Filter.Eq("InternalId", internalID);
            // update found document for the new status
            var update = Builders<Cat>.Update.Set("Name", name);
            try
            {
                UpdateResult actionResult
                    = await _context.Cats.UpdateOneAsync(filter, update);

                return actionResult.IsAcknowledged
                    && actionResult.ModifiedCount > 0;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
