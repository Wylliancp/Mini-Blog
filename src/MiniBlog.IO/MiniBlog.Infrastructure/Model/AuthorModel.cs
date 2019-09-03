using MiniBlog.Infrastructure.Model.Base;
using MongoDB.Bson.Serialization.Attributes;

namespace MiniBlog.Infrastructure.Model
{
    public class AuthorModel : BaseModel
    {
        [BsonElement("name")]
        public string Name { get; set; }
    }
}
