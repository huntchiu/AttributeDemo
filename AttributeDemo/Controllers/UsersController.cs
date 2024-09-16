using AttributeDemo.Models;
using Microsoft.AspNetCore.Mvc;

namespace AttributeDemo.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public IActionResult  Get()
        {
            return Ok( new {
                fileds = AttributeUtils.GetPropertyOfFileds<UserModel>()
            });
        }
    }
}