﻿using MiniBlog.Domain.Entities.Base;
using System.Collections.Generic;

namespace MiniBlog.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public string Text { get; set; }
        public Post Post { get; set; }
    }
}
