using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniBlog.Domain.Entities;
using MiniBlog.Domain.Service;

namespace MiniBlog.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostController : ControllerBase
    {
        private readonly IPostService _service;
        public PostController(IPostService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<Post>> Get()
        {
            return await _service.GetAll();
        }

        [HttpPost]
        public void Post([FromBody] Post post)
        {
            _service.Add(new Post()
            {
                Title = "Title",
                Text = "Text",
                Created = DateTime.Now,
                Author = new Author()
                {
                    Name = "Kid BB"
                },
                Comments = new List<Comment>() { new Comment { Text = "hahah aha ha" } }

            });
        }

    }
}