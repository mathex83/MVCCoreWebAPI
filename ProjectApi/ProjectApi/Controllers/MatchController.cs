using Microsoft.AspNetCore.Mvc;

namespace ProjectApi.Controllers
{
	public class MatchController : Controller
	{
		public IActionResult Create()
		{
			return View();
		}
	}
}
