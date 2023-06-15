using Microsoft.AspNetCore.Mvc;
using VascoVasconcellos.DAO.Interface.IService;
using VascoVasconcellos.Util.ProjectEnumeratos;
using VascoVasconcellos.DAO.Models;
using VascoVasconcellos.API.Areas.Vendas.VM;
using Microsoft.AspNetCore.Identity;

namespace VascoVasconcellos.API.Areas.Vendas.Controllers
{
    [Area("Vendas")]
    [Route("[area]/[controller]")]
    public class OrcamentosController : Controller
    {

        private readonly IServiceUsuario _servicioUsuario;
        private UserManager<AspNetUsers> _userManager;
        private readonly IServiceOrcamentos _serviceOrcamentos;
        private readonly IServiceVendas _serviceVendas;

        public OrcamentosController(
            IServiceUsuario servicioUsuario,
            UserManager<AspNetUsers> userManager,
            IServiceOrcamentos serviceOrcamentos,
            IServiceVendas serviceVendas

        )
        {
            _servicioUsuario = servicioUsuario;
            _userManager = userManager;
            _serviceOrcamentos = serviceOrcamentos;
            _serviceVendas = serviceVendas;
        }


        [HttpGet("Index")]
        public IActionResult Index()
        {
            var listaOrc = _serviceOrcamentos.Listar().ToList();
            return View(listaOrc);
        }

        [HttpGet("FinalizarOrcamento")]
        public IActionResult FinalizarOrcamento(int id) 
        { 
            var orcamento = _serviceOrcamentos.ObterPorIdOrcamentos(id);
            var vendas = _serviceVendas.ObterPorOrcamentoAprovRecus(orcamento.Id).ToList();
            bool sucesso = false;
            try
            {
                if(vendas.Count == 0)
                {
                    orcamento.Status = false;
                    sucesso = _serviceOrcamentos.Editar(orcamento);
                }

				return Json(new
				{
					Ok = sucesso,
					Title = sucesso ? "Sucesso" : "Erro",
					Message = sucesso ? "Sucesso ao mudar status do orçamento!" : "Erro ao mudar status, alguma venda desse orçamento não teve seu status atualizado!",
				});
			}
            catch(Exception e)
            {
				return Json(new
				{
					Ok = false,
					Title = "Erro",
					Message = e.InnerException?.Message ?? e.Message,
				});
			}
        }

    }
}
