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
    public class UsuarioController : Controller
    {

        private readonly IServiceUsuario _serviceUsuario;
        private UserManager<AspNetUsers> _userManager;
        private readonly IServiceLogErro _loggerErro;
        private readonly IServiceLogOperacao _loggerOperacao;
        public UsuarioController(
            IServiceUsuario serviceUsuario,
            UserManager<AspNetUsers> userManager,
            IServiceLogErro loggerErro,
            IServiceLogOperacao loggerOperacao
        )
        {
            _serviceUsuario = serviceUsuario;
            _userManager = userManager;
            _loggerErro = loggerErro;
            _loggerOperacao = loggerOperacao;
        }

        [HttpGet("Index")]
        public IActionResult Index()
        {
            var listaUsuario = _serviceUsuario.Listar().ToList();
            return View(listaUsuario);
        }

        [HttpGet("Adicionar")]
        public IActionResult Adicionar()
        {
            return View();
        }

        [HttpPost("AdicionarUsuario")]
        public async Task<IActionResult> AdicionarUsuario([FromBody] UsuarioVM model)
        {
            AspNetUsers userLogado = await _userManager.FindByNameAsync(User.Identity.Name);
            var usuario = _serviceUsuario.ObterPorIdAspNet(userLogado.Id);

            try
            {

                var user = new AspNetUsers
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
                if (sucesso)
                {
                    LogOperacao novoLogOperacao = new LogOperacao
                    {
                        IdUsuario = usuario.Id,
                        Data = DateTime.Now,
                        Status = "success",
                        Acao = "Adição de usuario"
                    };
                    _loggerOperacao.Adicionar(novoLogOperacao);
                }
                else
                {
                    LogErro novoLogErro = new LogErro
                    {
                        IdUsuario = usuario.Id,
                        Data = DateTime.Now,
                        Status = "Erro",
                        Erro = "Falha ao adicionar usuario, verificar método AspNet"

                    };
                    _loggerErro.Adicionar(novoLogErro);
                }

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
