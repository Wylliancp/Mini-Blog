using MiniBlog.Domain.Entities.Base;
using System.Collections.Generic;

namespace MiniBlog.Domain.Entities
{
    public class Post : BaseEntity
    {

        public string Title { get; set; }
        public string Text { get; set; }
        public int LikesCount { get; set; }

        public Author Author { get; set; }
        public ICollection<Comment> Comments { get; set; }
    }
}
