using MiniBlog.Domain.Entities.Base;

namespace MiniBlog.Domain.Entities
{
    public class Tenant : BaseEntity
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public string Title { get; set; }
    }
}
