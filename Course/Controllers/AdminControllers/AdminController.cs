
using Course.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Course.Controllers.AdminControllers
{
    public class CreateManagerModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    [ApiController]
    public class AdminController : ControllerBase
    {
        private AdminServices adminServices;

        public AdminController(AdminServices adminServices)
        {
            this.adminServices = adminServices;
        }

        [HttpGet("api/admin/users")]
        [Authorize(Roles = "admin")]
        public IActionResult GetUsers()
        {
            return Ok(adminServices.GetAllUsers());
        }

        [HttpPost("api/admin/create")]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> CreateManager([FromBody] CreateManagerModel model)
        {
            await adminServices.CreateManager(model);
            return Ok();
        }

    }
}