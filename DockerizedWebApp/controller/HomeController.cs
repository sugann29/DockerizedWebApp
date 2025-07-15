using Microsoft.AspNetCore.Mvc;

namespace DockerizedWebApp.controller
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
