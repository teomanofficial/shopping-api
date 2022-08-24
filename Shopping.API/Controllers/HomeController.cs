using Microsoft.AspNetCore.Mvc;

namespace Shopping.API.Controllers;

[Route("/")]
[ApiExplorerSettings(IgnoreApi = true)]
public class HomeController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return Redirect("/swagger/index.html");
    }
}