using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

using Sandbox.Models.Role;
using Sandbox.Models.Interfaces;

namespace Sandbox.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleManager _roleManager;

        public RoleController(IRoleManager roleManager)
        {
            _roleManager = roleManager;
        }
  
        // GET: api/Role
        [HttpGet]
        [ProducesResponseType(typeof(RoleEntity), 200)]
        public IActionResult Get()
        {
            IEnumerable<RoleEntity> roles = _roleManager.GetRoles();
            return Ok(roles);
        }
    }
}
