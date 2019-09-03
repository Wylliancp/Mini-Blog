using MiniBlog.Infrastructure.Model.Base;
using MongoDB.Bson.Serialization.Attributes;

namespace MiniBlog.Infrastructure.Model
{
    public class CommentModel : BaseModel
    {
        [BsonElement("text")]
        public string Text { get; set; }
        [BsonElement("author")]
        public AuthorModel Author { get; set; }

    }
}
