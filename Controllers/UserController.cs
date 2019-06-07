using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

using Sandbox.Models.User;
using Sandbox.Models.Repository;
 
namespace Sandbox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;
 
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
 
        // GET: api/User
        [HttpGet]
        [ProducesResponseType(typeof(UserEntity), 200)]
        public IActionResult Get()
        {
            IEnumerable<UserEntity> users = _userRepository.GetUsersWithRoles();
            return Ok(users);
        }
 
        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        [ProducesResponseType(typeof(UserEntity), 200)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public IActionResult Get(int id)
        {
            UserEntity user = _userRepository.GetUserWithRole(id);
 
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
        public IActionResult Post([FromBody] UserEntity user)
        {
            if (user == null)
            {
                return BadRequest("User is null.");
            }
 
            _userRepository.Add(user);
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
 
            UserEntity userToUpdate = _userRepository.GetUserWithRole(id);
            if (userToUpdate == null)
            {
                return NotFound("The User record couldn't be found.");
            }
 
            _userRepository.Update(userToUpdate, user);
            return NoContent();
        }
 
        // DELETE: api/User/5
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(void), 204)]
        [ProducesResponseType(typeof(IDictionary<string, string>), 400)]
        public IActionResult Delete(int id)
        {
            UserEntity user = _userRepository.GetUserWithRole(id);
            if (user == null)
            {
                return NotFound("The User record couldn't be found.");
            }
 
            _userRepository.Delete(user);
            return NoContent();
        }
    }
}
