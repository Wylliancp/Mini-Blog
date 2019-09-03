using MiniBlog.Domain.Entities;
using MiniBlog.Domain.Repository;
using MiniBlog.Domain.Service;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniBlog.Aplication.Service
{
    public class PostService : IPostService
    {
        private readonly IPostRepository _repository;
        public PostService(IPostRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Post>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task Add(Post obj)
        {
            await _repository.Add(obj);
        }

        public async Task AddComment(string postId, Comment comment)
        {
            await _repository.AddComment(postId, comment);
        }
    }
}
