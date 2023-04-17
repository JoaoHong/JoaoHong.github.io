using ConyGreen.API.Models;
using ConyGreen.DAO.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Emit;
using System.Text;
using System;
using ConyGreen.DAO.IService;
using ConyGreen.DAO.Models.VM;
using Microsoft.AspNetCore.Http.Metadata;
using Microsoft.AspNetCore.Authorization;

namespace ConyGreen.API.Areas.Gerenciamento.Controllers
{
	[Area("Gerenciamento")]
	[Route("[area]/[controller]")]
	[Authorize]
	public class UsuariosController : Controller
	{

		private readonly IServiceUsuario _serviceUsuario;
		private UserManager<AspNetUser> _userManager;

		public  UsuariosController(
			IServiceUsuario serviceUsuario,
			UserManager<AspNetUser> userManager
		)
		{
			_serviceUsuario = serviceUsuario;
			_userManager = userManager;
		}

		[HttpGet("Index")]
        public IActionResult Index()
        {
			var listaUsuarios = _serviceUsuario.Listar().ToList();
            return View(listaUsuarios);
        }

		[HttpGet("Adicionar")]
		public IActionResult Adicionar()
		{
			return View();
		}

		[HttpPost("AdicionarUsuario")]
		public async Task<IActionResult> AdicionarUsuario([FromBody] UsuarioVM model)
		{
			try
			{

				var user = new AspNetUser
				{
					UserName = model.Nome,
					TwoFactorEnabled = false, //Ativa a verificação em 2 etapas para o usuário
					Usuario = new Usuario
					{
						Nome = model.Nome,
						Senha = Convert.ToBase64String(Encoding.ASCII.GetBytes(model.Senha)),
						Ativo = true,
					}
				};


				var chkUser = await _userManager.CreateAsync(user, model.Senha);

				bool sucesso = chkUser.Succeeded;

				return Json(new
				{
					Ok = sucesso,
					Title = sucesso ? "Sucesso" : "Erro",
					Message = sucesso ? "Sucesso ao adicionar o usuário!" : "Erro ao adicionar o usuário!",
				});
			}
			catch (Exception e)
			{
				return Json(new
				{
					Ok = false,
					Title = "Erro",
					Message = e.InnerException?.Message ?? e.Message,
				});
			}
		}

		[HttpGet("ExcluirUsuario")]
		public async Task<IActionResult> ExcluirUsuario(int id)
		{
			try
			{
				var sucesso = false;

				sucesso = _serviceUsuario.Deletar(id);

				return Json(new
				{
					Ok = sucesso,
					Title = sucesso ? "Sucesso" : "Erro",
					Message = sucesso ? "Sucesso ao excluir o usuário!" : "Erro ao excluir o usuário!",
				});
			}
			catch (Exception e)
			{
				return Json(new
				{
					Ok = false,
					Title = "Erro",
					Message = e.InnerException?.Message ?? e.Message,
				});
			}
			
			
		}

		[HttpGet("Editar")]
		public IActionResult Editar()
		{
			return View();
		}

	}
}
