using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;

namespace myFirstProject.Models
{
    public class Cat
    {
        [BsonId]
        public ObjectId InternalId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;
    }
}
