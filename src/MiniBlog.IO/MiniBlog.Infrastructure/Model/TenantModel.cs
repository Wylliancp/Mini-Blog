using MiniBlog.Infrastructure.Model.Base;

namespace MiniBlog.Infrastructure.Model
{
    public class TenantModel : BaseModel
    {
        public string Name { get; set; }
        public string Host { get; set; }
        public string Title { get; set; }
    }
}
