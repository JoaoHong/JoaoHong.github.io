using Microsoft.AspNetCore.Mvc;
using ConyGreen.DAO.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Caching.Memory;
using ConyGreen.DAO.Models.VM;
using ConyGreen.DAO.IService;
using Microsoft.AspNetCore.Authorization;

namespace ConyGreen.API.Controllers
{
	[Route("[controller]")]
	public class AccountController : Controller
	{
		private readonly ILogger<AccountController> _logger;
		private UserManager<AspNetUser> _userManager;
		private RoleManager<IdentityRole> _roleManager;
		private SignInManager<AspNetUser> _signInManager;
		private readonly IMemoryCache _memoryCache;
		private readonly IServiceLogAcesso _serviceLogAcesso;
		private readonly IServiceUsuario _serviceUsuario;

		public AccountController(
			ILogger<AccountController> logger,
			UserManager<AspNetUser> userManager, 
			RoleManager<IdentityRole> roleManager, 
			SignInManager<AspNetUser> signInManager,
			IMemoryCache memoryCache,
			IServiceLogAcesso serviceLogAcesso,
			IServiceUsuario serviceUsuario
			)
		{
			_logger = logger;
			_userManager = userManager;
			_roleManager = roleManager;
			_signInManager = signInManager;
			_memoryCache = memoryCache;
			_serviceLogAcesso = serviceLogAcesso;	
			_serviceUsuario = serviceUsuario;
		}

		[HttpGet("Login")]
		public IActionResult Login()
		{
			if (!User.Identity.IsAuthenticated)
			{
				return View();
			}
			else
			{
				return RedirectToAction("Index", "Dashboard");
			}
		}

		[HttpPost("Login")]
		public async Task<IActionResult> Login([FromBody] LogInVM model)
		{
			if (!ModelState.IsValid) return Json(new { Ok = false, Title = "Erro", Message = "Dados inválidos!" });

			var user = _userManager.ObterPorUserName(model.Nome);

			if (user == null)
			{
				return Json(new
				{
					Ok = false,
					Title = "Erro",
					Message = "Nome ou senha incorreto!",
				});
			}

			if (await _userManager.IsLockedOutAsync(user))
			{
				var now = DateTimeOffset.Now;
				var end = user.LockoutEnd.Value;
				var minutes = Math.Ceiling((end - now).TotalMinutes);
				return Json(new
				{
					Ok = false,
					Title = "Erro",
					Message = $"Devido a várias tentativas de acesso, a sua conta foi bloqueada. Tente novamente em {minutes + (minutes == 1 ? " minuto" : " minutos")}!",
				});
			}

			var result = await _signInManager.PasswordSignInAsync(user, model.Password, true, true);

			var usuario = _serviceUsuario.ObterPorIdAspNet(user.Id);

			if (!result.Succeeded)
			{
				GerarLogAcesso(usuario.Id, false);

				return Json(new
				{
					Ok = false,
					Title = "Erro",
					Message = "Nome ou senha incorreto!",
				});
			}

			return Json(new
			{
				Ok = true,
				Title = "Sucesso",
				Message = "Sucesso na confirmação de login e senha!",
			});
		}

		[Authorize]
		[HttpGet("Logout")]
		public IActionResult Logout()
		{
			foreach (var cookie in Request.Cookies)
			{
				if (cookie.Key == "acceptCookies") continue;
				Response.Cookies.Delete(cookie.Key);
			}

			return RedirectToAction("Login", "Account");
		}

		public bool GerarLogAcesso(int id, bool status)
		{
			var LogAcesso = new LogAcesso
			{
				IdUsuario = id,
				Data = DateTime.Now,
				Status = status,
			};
			return _serviceLogAcesso.Adicionar(LogAcesso);
		}
	}
}
