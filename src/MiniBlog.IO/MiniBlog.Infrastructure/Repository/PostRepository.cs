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
            //var post = _mapper.Map<PostModel>(obj);

            var post = new PostModel()
            {
                Title = "Title LEANDRO SILVEIRA",
                Text = "Text  123",
                Created = DateTime.Now,
                Author = new AuthorModel()
                {
                    Name = "Kid BB"
                },
                Comments = new List<CommentModel>() { new CommentModel { Text = "hahah aha ha" } }

            };
            _dbContext.Posts.InsertOne(post);
            return Task.CompletedTask;
        }


        public async Task<IEnumerable<Post>> GetAll()
        {
            var posts = _dbContext.Posts.AsQueryable().ToList();
            return _mapper.Map<IEnumerable<Post>>(posts);
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
