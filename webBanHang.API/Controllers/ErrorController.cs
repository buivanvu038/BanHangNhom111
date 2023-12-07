using Microsoft.AspNetCore.Mvc;

namespace webBanHang.API.Controllers
{
    [ApiController]
    public class ErrorController : Controller
    {

        [Route("/error")]
        [HttpGet]
        public IActionResult Error()
        {
            return Problem();
        }
        [Route("/error/test")]
        [HttpGet]
        public IActionResult Test() 
        { 
            throw new Exception("test"); 
        }
    }
}
