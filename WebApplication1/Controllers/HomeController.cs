using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/ModelsClasses/")]
    public class HomeController : Controller
    {
    
        [HttpPost]
        public IActionResult CreateUser([FromBody] ModelClass newHomeController)
        {

            return Ok($"User {newHomeController.Name} created , Age : {newHomeController.Age} ");
        }
    }
}
