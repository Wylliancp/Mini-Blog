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
        private readonly IMapper _mapper;
        private readonly DbContext _dbContext;

        public PostRepository(DbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public Task Add(Post obj)
        {
            return _dbContext.Posts.InsertOneAsync(_mapper.Map<PostModel>(obj));
        }

        public Task AddComment(string postId, Comment comment)
        {
            var _comment = _mapper.Map<CommentModel>(comment);

            var _id = MongoDB.Bson.ObjectId.Parse(postId);

            var filter = Builders<PostModel>.Filter.And(
                         Builders<PostModel>.Filter.Where(x => x.Id == _id));
            var update = Builders<PostModel>.Update.Push(x => x.Comments, _comment);

            return _dbContext.Posts.FindOneAndUpdateAsync(filter, update);
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
