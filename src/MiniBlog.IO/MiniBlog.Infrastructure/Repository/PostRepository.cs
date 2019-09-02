using MiniBlog.Domain.Entities;
using MiniBlog.Domain.Repository.Base;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBlog.Infrastructure.Repository
{

    public class PostRepository : IBaseRepository<Post>
    {

        private DbContext _dbContext;
        public PostRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task Add(Post obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Post>> GetAll()
        {
            return await _dbContext.Posts.AsQueryable().ToList();
        }

        public Task<Post> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(Post obj)
        {
            throw new NotImplementedException();
        }
    }
}
