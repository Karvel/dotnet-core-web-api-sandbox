using System.Collections.Generic;
using Sandbox.Models;
using Sandbox.Models.Repository;
using Microsoft.AspNetCore.Mvc;
 
namespace Sandbox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleRepository _roleRepository;
 
        public RoleController(IRoleRepository RoleRepository)
        {
            _roleRepository = RoleRepository;
        }
 
        // GET: api/Role
        [HttpGet]
        public IActionResult Get()
        {
            IEnumerable<Role> roles = _roleRepository.GetAll();
            return Ok(roles);
        }
    }
}
