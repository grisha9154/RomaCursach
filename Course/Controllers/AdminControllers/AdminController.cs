
using Course.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Course.Controllers.AdminControllers
{
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

        [HttpGet("api/admin/orders")]
        [Authorize(Roles ="admin")]
        public IActionResult GetOrders()
        {
            return Ok(adminServices.GetOrders());
        }
    }
}