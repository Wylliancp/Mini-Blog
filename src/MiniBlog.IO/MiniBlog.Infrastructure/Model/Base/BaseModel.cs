using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace MiniBlog.Infrastructure.Model.Base
{
    public abstract class BaseModel
    {
        [BsonId, BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public bool IsDeleted { get; set; }
    }
}
