using MiniBlog.Domain.Entities.Base;

namespace MiniBlog.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Text { get; set; }
        public Author Author { get; set; }
    }
}
