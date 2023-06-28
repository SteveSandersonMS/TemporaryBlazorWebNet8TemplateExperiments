using Microsoft.AspNetCore.Mvc;

namespace MyBlazorWeb.Controllers;

public class MyApiController : Controller
{
    public IActionResult Index()
    {
        return Json(new { Abc = 123 });
    }
}
