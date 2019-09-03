using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using System;

namespace MiniBlog.Infrastructure.Model.Base
{
    public abstract class BaseModel
    {
        [BsonId]
        [BsonElement("_id")]
        public ObjectId Id { get; set; }
        [BsonElement("created")]
        public DateTime Created { get; set; }
        [BsonElement("modified")]
        public DateTime Modified { get; set; }
        [BsonElement("isdeleted")]

        public bool IsDeleted { get; set; }
    }
}
