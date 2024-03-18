using Domain;
using Microsoft.AspNetCore.Mvc;

namespace RestAPI.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("GetUser")]
        public IActionResult GetUser(int ID)
        {
            return StatusCode(501);
        }

        [HttpPost]
        [Route("CreateUser")]
        public IActionResult CreateUser(User user)
        {
            return StatusCode(501);
        }

        [HttpPut]
        [Route("UpdateUser")]
        public IActionResult UpdateUser(User user)
        {
            return StatusCode(501);
        }

        [HttpDelete]
        [Route("DeleteUser")]
        public IActionResult DeleteUser(int ID)
        {
            return StatusCode(501);
        }
    }
}
