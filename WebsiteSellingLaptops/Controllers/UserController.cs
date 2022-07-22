using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace WebsiteSellingLaptops.Controllers
{
    [Route("api/Users")]
    public class UserController : Controller
    {   
        public UserController() { }
        
        [HttpGet]
        [Route("GetAllUsers")]
        public IActionResult GetAllUsers()
        {
            return StatusCode(200,"That is ok!")  ;
        }
    }
}
