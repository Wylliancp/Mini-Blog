﻿using System;

namespace MiniBlog.Domain.Entities.Base
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public bool IsDeleted { get; set; }
    }
}
