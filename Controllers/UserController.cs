using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using Sandbox.Models.Interfaces;
using Sandbox.Models.User;
 
namespace Sandbox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
 
        public UserController(IUserService userService)
        {
            _userService = userService;
        }
 
        // GET: api/User
        [HttpGet]
        [ProducesResponseType(typeof(UserEntity), 200)]
        public ActionResult<IEnumerable<UserEntity>> Get()
        {
            IEnumerable<UserEntity> users = _userService.GetUsers();
            return Ok(users);
        }
 
        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        [ProducesResponseType(typeof(UserEntity), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public ActionResult<UserEntity> Get(int id)
        {
            UserEntity user = _userService.GetUser(id);
 
            if (user == null)
            {
                return NotFound("The User record couldn't be found.");
            }
 
            return Ok(user);
        }
 
        // POST: api/User
        [HttpPost]
        [ProducesResponseType(typeof(UserEntity), 201)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public ActionResult<UserEntity> Post([FromBody] UserEntity user)
        {
            if (user == null)
            {
                return BadRequest("User is null.");
            }
 
            _userService.AddUser(user);
            return CreatedAtRoute(
                  "Get", 
                  new { Id = user.Id },
                  user);
        }
 
        // PUT: api/User/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] UserEntity user)
        {
            if (user == null)
            {
                return BadRequest("User is null.");
            }
 
            UserEntity userToUpdate = _userService.GetUser(id);
            if (userToUpdate == null)
            {
                return NotFound("The User record couldn't be found.");
            }
 
            _userService.UpdateUser(userToUpdate, user);
            return NoContent();
        }
 
        // DELETE: api/User/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(void), 204)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public IActionResult Delete(int id)
        {
            UserEntity user = _userService.GetUser(id);
            if (user == null)
            {
                return NotFound("The User record couldn't be found.");
            }
 
            _userService.DeleteUser(user);
            return NoContent();
        }
    }
}
