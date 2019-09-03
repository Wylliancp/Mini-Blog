using MiniBlog.Domain.Entities;
using MiniBlog.Domain.Repository.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MiniBlog.Domain.Repository
{
    public interface IPostRepository : IBaseRepository<Post>
    {
        Task AddComment(string postId, Comment comment);
    }
}
