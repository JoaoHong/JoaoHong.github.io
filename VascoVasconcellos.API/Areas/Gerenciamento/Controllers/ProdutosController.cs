using VascoVasconcellos.API.Models;
using VascoVasconcellos.DAO.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Emit;
using System.Text;
using System;
using VascoVasconcellos.DAO.Interface.IService;
using VascoVasconcellos.DAO.Models.VM;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Authorization;

namespace VascoVasconcellos.API.Areas.Gerenciamento.Controllers
{
	[Area("Gerenciamento")]
	[Route("[area]/[controller]")]
	[Authorize]
	public class ProdutosController : Controller
	{

		private readonly IServiceProdutos _serviceProdutos;
		private readonly IServiceProdutosColunas _serviceProdutosColunas;

		public ProdutosController
		(
			IServiceProdutos serviceProdutos,
			IServiceProdutosColunas serviceProdutosColunas
		)
		{
			_serviceProdutos = serviceProdutos;
			_serviceProdutosColunas = serviceProdutosColunas;
		}


		public IActionResult Index()
		{
			return View();
		}

		[HttpGet("GetProdutosColunas")]
		public IActionResult GetProdutosColunas(int IdProduto)
		{
			var produtosColunas = _serviceProdutosColunas.ObterPorIdProdutos(IdProduto);

			return Json(produtosColunas);
		}

	}
}
