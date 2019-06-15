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
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }
  
        // GET: api/Role
        [HttpGet]
        [ProducesResponseType(typeof(RoleEntity), 200)]
        public IActionResult Get()
        {
            IEnumerable<RoleEntity> roles = _roleService.GetRoles();
            return Ok(roles);
        }
    }
}
