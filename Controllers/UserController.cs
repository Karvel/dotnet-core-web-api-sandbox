using System.Collections.Generic;
using Sandbox.Models;
using Sandbox.Models.Repository;
using Microsoft.AspNetCore.Mvc;
 
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
        public IActionResult Get()
        {
            IEnumerable<User> users = _userRepository.GetUsersWithRoles();
            return Ok(users);
        }
 
        // GET: api/User/5
        [HttpGet("{id}", Name = "Get")]
        public IActionResult Get(int id)
        {
            User user = _userRepository.GetUserWithRole(id);
 
            if (user == null)
            {
                return NotFound("The User record couldn't be found.");
            }
 
            return Ok(user);
        }
 
        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User is null.");
            }
 
            _userRepository.Add(user);
            return CreatedAtRoute(
                  "Get", 
                  new { Id = user.UserId },
                  user);
        }
 
        // PUT: api/User/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User user)
        {
            if (user == null)
            {
                return BadRequest("User is null.");
            }
 
            User userToUpdate = _userRepository.GetUserWithRole(id);
            if (userToUpdate == null)
            {
                return NotFound("The User record couldn't be found.");
            }
 
            _userRepository.Update(userToUpdate, user);
            return NoContent();
        }
 
        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            User user = _userRepository.GetUserWithRole(id);
            if (user == null)
            {
                return NotFound("The User record couldn't be found.");
            }
 
            _userRepository.Delete(user);
            return NoContent();
        }
    }
}
