using Domain;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    [ApiController]
    public class BlogController : ControllerBase
    {
        [HttpGet]
        [Route("GetBlog")]
        public IActionResult GetBlog(int ID)
        {
            return StatusCode(501);
        }

        [HttpPost]
        [Route("CreateBlog")]
        public IActionResult CreateBlog(Blog blog)
        {
            return StatusCode(501);
        }

        [HttpPut]
        [Route("UpdateBlog")]
        public IActionResult PutBlog(Blog blog)
        {
            return StatusCode(501);
        }

        [HttpDelete]
        [Route("DeleteBlog")]
        public IActionResult DeleteBlog(int ID)
        {
            return StatusCode(501);
        }
    }
}
