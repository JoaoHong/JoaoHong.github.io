using ConyGreen.DAO.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ConyGreen.API.Areas.Teste.Controllers
{

	[Area("Teste")]
	[Route("[area]/[controller]")]
	[Authorize]
	public class TesteController : Controller
	{
		[HttpGet("Index")]
		public IActionResult Index()
		{
			return View();
		}
	}
}
