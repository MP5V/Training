using Microsoft.AspNetCore.Mvc;

namespace WebApplication1
{
    public class Controllers
    {
        [ApiController]
        [Route("api/[controller]")]
        public class UsersController : ControllerBase
        {
            [HttpGet]
            public IActionResult GetAll()
            {
                return Ok(new[] { "Anna", "Bob" });
            }

            [HttpGet("{id}")]
            public IActionResult Get(int id)
            {
                return Ok($"Пользователь {id}");
            }
        }
    }
}
