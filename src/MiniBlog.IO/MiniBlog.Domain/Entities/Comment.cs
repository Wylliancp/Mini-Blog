using MiniBlog.Domain.Entities.Base;

namespace MiniBlog.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Text { get; set; }
        public string AuthorId { get; set; }
    }
}
