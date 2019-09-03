using System.Collections.Generic;
using System.Threading.Tasks;
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
            _service.Add(post);
        }

    }
}