using MiniBlog.Infrastructure.Model.Base;
using System.Collections.Generic;

namespace MiniBlog.Infrastructure.Model
{
    public class AuthorModel : BaseModel
    {
        public string Name { get; set; }
        public ICollection<PostModel> Posts { get; set; }
    }
}
