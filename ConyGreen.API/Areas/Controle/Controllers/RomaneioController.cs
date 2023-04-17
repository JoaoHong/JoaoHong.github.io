using ConyGreen.DAO.IService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ConyGreen.API.Areas.Controle.Controllers
{
	[Area("Controle")]
	[Route("[area]/[controller]")]
	[Authorize]
	public class RomaneioController : Controller
	{
		private readonly IServiceRomaneio _serviceRomaneio;

		public RomaneioController(IServiceRomaneio serviceRomaneio)
		{
			_serviceRomaneio = serviceRomaneio;
		}

		[HttpGet("Index")]
		public IActionResult Index()
		{
			var listaRomaneio = _serviceRomaneio.Listar().ToList();
			return View(listaRomaneio);
		}

		[HttpGet("GerarImpressao")]
		public IActionResult GerarImpressao()
		{
			return View();
		}

		[HttpGet("AddToimpressao")]
		public IActionResult AddToImpressao(int corte)
		{
			var retorno = _serviceRomaneio.ObterPorCorte(corte);
			return Json(retorno);
		}

	}
}
