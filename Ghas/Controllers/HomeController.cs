using Microsoft.AspNetCore.Mvc;

namespace Ghas.Controllers;

[ApiController]
[Route("/")]
public class HomeController : ControllerBase
{
    public IActionResult Index()
    {
        return Content("Hello, World!");
    }
}