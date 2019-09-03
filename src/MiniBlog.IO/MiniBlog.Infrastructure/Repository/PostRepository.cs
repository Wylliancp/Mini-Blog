using AutoMapper;
using MiniBlog.Domain.Entities;
using MiniBlog.Domain.Repository;
using MiniBlog.Infrastructure.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniBlog.Infrastructure.Repository
{

    public class PostRepository : IPostRepository
    {
        protected IMapper _mapper;

        private DbContext _dbContext;
        public PostRepository(DbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Task Add(Post obj)
        {
            _dbContext.Posts.InsertOne(_mapper.Map<PostModel>(obj));
            return Task.CompletedTask;
        }


        public async Task<IEnumerable<Post>> GetAll()
        {
            return _mapper.Map<IEnumerable<Post>>(_dbContext.Posts.AsQueryable().ToList());
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
