using MiniBlog.Domain.Entities;
using MiniBlog.Domain.Service.Base;
using System.Threading.Tasks;

namespace MiniBlog.Domain.Service
{
    public interface IPostService : IBaseService<Post>
    {
        Task AddComment(string postId, Comment comment);
    }
}
