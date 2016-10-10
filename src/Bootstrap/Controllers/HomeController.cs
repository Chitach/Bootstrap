using Microsoft.AspNetCore.Mvc;

namespace Bootstrap.Controllers {
	[Route("[controller]/[action]")]
	public class HomeController : Controller {
		public IActionResult Index() {
			return View("~/Views/Index.cshtml");
		}
	}
}
