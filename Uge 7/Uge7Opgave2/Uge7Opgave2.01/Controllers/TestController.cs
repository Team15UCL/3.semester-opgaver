using Microsoft.AspNetCore.Mvc;

namespace Uge7Opgave2._01.Controllers;
public class TestController : Controller
{
	public IActionResult Index()
	{
		return View();
	}

	public IActionResult NewPage()
	{
		return View();
	}
}
