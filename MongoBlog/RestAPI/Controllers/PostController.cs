using Domain;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    [ApiController]
    public class PostController : ControllerBase
    {
        [HttpGet]
        [Route("GetPosts")]
        public IActionResult GetPosts(int BlogID)
        {
            return StatusCode(501);
        }

        [HttpPost]
        [Route("CreatePost")]
        public IActionResult PostPost(Post post)
        {
            return StatusCode(501);
        }

        [HttpPut]
        [Route("UpdatePost")]
        public IActionResult PutPost(Post post)
        {
            return StatusCode(501);
        }

        [HttpDelete]
        [Route("DeletePost")]
        public IActionResult DeletePost(int id)
        {
            return StatusCode(501);
        }
    }
}
