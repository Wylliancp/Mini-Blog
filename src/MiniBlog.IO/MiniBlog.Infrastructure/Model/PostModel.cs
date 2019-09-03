using MiniBlog.Infrastructure.Model.Base;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;

namespace MiniBlog.Infrastructure.Model
{
    public class PostModel : BaseModel
    {
        public string Title { get; set; }
        public string Text { get; set; }
        public int LikesCount { get; set; }
        public AuthorModel Author { get; set; }
        public ICollection<CommentModel> Comments { get; set; }
    }
}
