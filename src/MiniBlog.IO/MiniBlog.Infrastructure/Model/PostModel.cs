using MiniBlog.Infrastructure.Model.Base;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace MiniBlog.Infrastructure.Model
{
    [BsonIgnoreExtraElements]
    public class PostModel : BaseModel
    {
        [BsonElement("title")]
        public string Title { get; set; }
        [BsonElement("text")]
        public string Text { get; set; }
        [BsonElement("likes")]
        public int LikesCount { get; set; }
        [BsonElement("author")]
        public AuthorModel Author { get; set; }
        [BsonElement("comments")]
        public ICollection<CommentModel> Comments { get; set; }
    }
}
