using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;


[Route("api/[controller]")]
[ApiController]
public class HomeController : ControllerBase
{

    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Hello World!");
    }
}