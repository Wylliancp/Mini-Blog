﻿using MiniBlog.Domain.Entities.Base;
using System.Collections.Generic;

namespace MiniBlog.Domain.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }

        public ICollection<Post> Posts { get; set; }
    }
}
