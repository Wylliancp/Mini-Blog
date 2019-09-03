using MiniBlog.Domain.Entities.Base;
using System.Collections.Generic;

namespace MiniBlog.Domain.Entities
{
    public class Author : User
    {
        public ICollection<Post> Posts { get; set; }
    }
}
