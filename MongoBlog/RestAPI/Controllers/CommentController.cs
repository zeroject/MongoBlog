using Domain;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    [ApiController]
    public class CommentController : ControllerBase
    {
        [HttpPost]
        [Route("CreateComment")]
        public IActionResult PostComment(Comment comment)
        {
            return StatusCode(501);
        }

        [HttpPut]
        [Route("UpdateComment")]
        public IActionResult PutComment(Comment comment)
        {
            return StatusCode(501);
        }

        [HttpDelete]
        [Route("DeleteComment")]
        public IActionResult DeleteComment(int id)
        {
            return StatusCode(501);
        }
    }
}
