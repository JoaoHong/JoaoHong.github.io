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
    public class VendasController : Controller
    {
        private readonly IServiceVendas _serviceVendas;
        private readonly IServiceProdutos _serviceProdutos;
        private readonly IServiceClientes _serviceClientes;
        private readonly IServiceOrcamentos _serviceOrcamentos;
        private readonly IServiceUsuario _serviceUsuario;
        private UserManager<AspNetUsers> _userManager;

        public VendasController(
            IServiceVendas serviceVendas,
            IServiceProdutos serviceProdutos,
            IServiceClientes serviceClientes,
            IServiceOrcamentos serviceOrcamentos,
            IServiceUsuario serviceUsuario,
            UserManager<AspNetUsers> userManager
        )
        {
            _serviceVendas = serviceVendas;
            _serviceProdutos = serviceProdutos;
            _serviceClientes = serviceClientes;
            _serviceOrcamentos = serviceOrcamentos;
            _serviceUsuario = serviceUsuario;
            _userManager = userManager;
        }

        [HttpGet("Index")]
        public IActionResult Index(int idOrc)
        {
            ViewBag.IdOrcamento = idOrc;
            var listaVendas = _serviceVendas.ListarPorIdOrcamento(idOrc).ToList();
            return View(listaVendas);
        }

        [HttpGet("Adicionar")]
		public IActionResult Adicionar(int idOrcamento)
		{
            ViewBag.IdOrcamento = idOrcamento;
            ViewBag.Clientes = _serviceClientes.Listar().ToList();
            ViewBag.Produtos = _serviceProdutos.Listar().ToList();
			return View();
		}

        [HttpGet("AdicionarPrimeiraVenda")]
        public IActionResult AdicionarPrimeiraVenda()
        {
			ViewBag.Clientes = _serviceClientes.Listar().ToList();
			ViewBag.Produtos = _serviceProdutos.Listar().ToList();
			return View();
        }

		[HttpPost("AdicionarVendaFirst")]
		public async Task<IActionResult> AdicionarVendaFirst([FromBody] VendasVM model)
		{
			AspNetUsers userLogado = await _userManager.FindByNameAsync(User.Identity.Name);
			var usuario = _serviceUsuario.ObterPorIdAspNet(userLogado.Id);
			var res = ModelState;
			try
			{
                Orcamentos newOrcamento = new Orcamentos
                {
                    IdComprador = model.IdCliente,
					DataAbertura = DateTime.Now,
					IdVendedor = usuario.Id,
					Status = true,
				};

				bool sucesso1 = _serviceOrcamentos.Adicionar(newOrcamento);

                if (sucesso1)
                {
					var UltimaVenda = _serviceVendas.LastOS();
					var LastOS = 1500;
					if (UltimaVenda != null)
					{
						LastOS = (int)(UltimaVenda.OS + 1);
					}
                    var orc = _serviceOrcamentos.ObterLastOrcPorVendedor(usuario.Id);

					DAO.Models.Vendas vendaNova = new DAO.Models.Vendas
					{
						OS = LastOS,
						PrevisaoEntrega = model.PrevisaoEntrega,
						Valor = new decimal(model.Valor),
						Faturamento = model.Faturamento,
						IdProduto = model.IdProduto,
						Modelo = model.Modelo,
						Producao = model.Producao,
						Base = model.Base,
						Artigo = model.Artigo,
						CorArtigo = model.CorArtigo,
						Quantidade = model.Quantidade,
						Forro = model.Forro,
						CorForro = model.CorForro,
						CorPespontoExterno = model.CorPespontoExterno,
						CorPespontoInterno = model.CorPespontoInterno,
						CorVivo = model.CorVivo,
						CorGola = model.CorGola,
						Botao = model.Botao,
						CorLinhaBotao = model.CorLinhaBotao,
						CorFraseGolaB = model.CorFraseGolaB,
						CorFraseB = model.CorFraseB,
						FraseInterna = model.FraseInterna,
						CorFraseInterna = model.CorFraseInterna,
						CorCaseado = model.CorCaseado,
						CorUltimoCaseado = model.CorUltimoCaseado,
						InformacoesAdicionais = model.InformacoesAdicionais,
						ModeloColarinho = model.ModeloColarinho,
						Bolso = model.Bolso,
						GiroManga = model.GiroManga,
						CorGiroManga = model.CorGiroManga,
						Monograma = model.Monograma,
						CorMonograma = model.CorMonograma,
						Iniciais = model.Iniciais,
						AcabamentoLateral = model.AcabamentoLateral,
						Evento = model.Evento,
						IdOrcamento = orc.Id,
						Conjunto = model.Conjunto,
						Status = 0,
						Entregue = model.Entregue,
						IdUsuario = model.IdUsuario,
						Punho = model.Punho,
						IdVendedor = usuario.Id,
						CodigoDeBarras = model.CodigoDeBarras,
						DescricaoCodBarras = model.DescricaoCodBarrras
					};

					bool sucesso = _serviceVendas.Adicionar(vendaNova);

					return Json(new
					{
						Ok = sucesso,
						Title = sucesso ? "Sucesso" : "Erro",
						Message = sucesso ? "Sucesso ao adicionar venda e orçamento!" : "Erro ao adicionar a venda e orçamento!",
					});
                }
                else
                {
                    return Json(new
					{
						Ok = sucesso1,
						Title = sucesso1 ? "Sucesso" : "Erro",
						Message = sucesso1 ? "Sucesso ao adicionar orçamento!" : "Erro ao adicionar a orçamento!",
					});
                }
				

				
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

		[HttpPost("AdicionarVenda")]
        public async Task<IActionResult> AdicionarVenda([FromBody]VendasVM model)
        {
            AspNetUsers userLogado = await _userManager.FindByNameAsync(User.Identity.Name);
            var usuario = _serviceUsuario.ObterPorIdAspNet(userLogado.Id);
            var res = ModelState;
            try
            {
                var UltimaVenda = _serviceVendas.LastOS();
                var LastOS = 1500;
                if (UltimaVenda != null)
                {
					LastOS = (int)(UltimaVenda.OS + 1);
				}

                DAO.Models.Vendas vendaNova = new DAO.Models.Vendas
                {
                    OS = LastOS,
                    PrevisaoEntrega = model.PrevisaoEntrega,
                    Valor = new decimal(model.Valor),
                    Faturamento = model.Faturamento,
                    IdProduto = model.IdProduto,
                    Modelo = model.Modelo,
                    Producao = model.Producao,
                    Base = model.Base,
                    Artigo = model.Artigo,
                    CorArtigo = model.CorArtigo,
                    Quantidade  = model.Quantidade,
                    Forro = model.Forro,
                    CorForro = model.CorForro,
                    CorPespontoExterno = model.CorPespontoExterno,
                    CorPespontoInterno = model.CorPespontoInterno,
                    CorVivo = model.CorVivo,
                    CorGola = model.CorGola,
                    Botao = model.Botao,
                    CorLinhaBotao = model.CorLinhaBotao,
                    CorFraseGolaB = model.CorFraseGolaB,
                    CorFraseB = model.CorFraseB,
                    FraseInterna = model.FraseInterna,
                    CorFraseInterna = model.CorFraseInterna,
                    CorCaseado = model.CorCaseado,
                    CorUltimoCaseado = model.CorUltimoCaseado,
                    InformacoesAdicionais = model.InformacoesAdicionais,
                    ModeloColarinho = model.ModeloColarinho,
                    Bolso = model.Bolso,
                    GiroManga = model.GiroManga,
                    CorGiroManga = model .CorGiroManga,
                    Monograma = model.Monograma,
                    CorMonograma = model .CorMonograma,
                    Iniciais = model.Iniciais,
                    AcabamentoLateral = model.AcabamentoLateral,
                    Evento = model.Evento,
                    IdOrcamento = model.IdOrcamento,
                    Conjunto = model.Conjunto,
                    Status = 0,
                    Entregue = model.Entregue,
                    IdUsuario = model.IdUsuario,
                    Punho = model.Punho,          
                    IdVendedor = usuario.Id,
                    CodigoDeBarras = model.CodigoDeBarras,
                    DescricaoCodBarras = model.DescricaoCodBarrras
                };
                
                bool sucesso = _serviceVendas.Adicionar(vendaNova);

				return Json(new
				{
					Ok = sucesso,
					Title = sucesso ? "Sucesso" : "Erro",
					Message = sucesso ? "Sucesso ao adicionar venda!" : "Erro ao adicionar a venda!",
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

		[HttpPost("EditarVenda")]
		public async Task<IActionResult> EditarVenda([FromBody] VendasVM model)
		{
			AspNetUsers userLogado = await _userManager.FindByNameAsync(User.Identity.Name);
			var usuario = _serviceUsuario.ObterPorIdAspNet(userLogado.Id);
			var res = ModelState;
			try
			{

				DAO.Models.Vendas vendaNova = _serviceVendas.ObterPorIdVendas(model.Id);
				vendaNova.PrevisaoEntrega = model.PrevisaoEntrega;
				vendaNova.Valor = new decimal(model.Valor);
				vendaNova.Faturamento = model.Faturamento;
				vendaNova.Modelo = model.Modelo;
				vendaNova.Producao = model.Producao;
				vendaNova.Base = model.Base;
				vendaNova.Artigo = model.Artigo;
				vendaNova.CorArtigo = model.CorArtigo;
				vendaNova.Quantidade = model.Quantidade;
				vendaNova.Forro = model.Forro;
				vendaNova.CorForro = model.CorForro;
				vendaNova.CorPespontoExterno = model.CorPespontoExterno;
				vendaNova.CorPespontoInterno = model.CorPespontoInterno;
				vendaNova.CorVivo = model.CorVivo;
				vendaNova.CorGola = model.CorGola;
				vendaNova.Botao = model.Botao;
				vendaNova.CorLinhaBotao = model.CorLinhaBotao;
				vendaNova.CorFraseGolaB = model.CorFraseGolaB;
				vendaNova.CorFraseB = model.CorFraseB;
				vendaNova.FraseInterna = model.FraseInterna;
				vendaNova.CorFraseInterna = model.CorFraseInterna;
				vendaNova.CorCaseado = model.CorCaseado;
				vendaNova.CorUltimoCaseado = model.CorUltimoCaseado;
				vendaNova.InformacoesAdicionais = model.InformacoesAdicionais;
				vendaNova.ModeloColarinho = model.ModeloColarinho;
				vendaNova.Bolso = model.Bolso;
				vendaNova.GiroManga = model.GiroManga;
				vendaNova.CorGiroManga = model.CorGiroManga;
				vendaNova.Monograma = model.Monograma;
				vendaNova.CorMonograma = model.CorMonograma;
				vendaNova.Iniciais = model.Iniciais;
				vendaNova.AcabamentoLateral = model.AcabamentoLateral;
				vendaNova.Evento = model.Evento;
				vendaNova.Conjunto = model.Conjunto;
				vendaNova.Entregue = model.Entregue;
				vendaNova.IdUsuario = model.IdUsuario;
				vendaNova.Punho = model.Punho;
				vendaNova.CodigoDeBarras = model.CodigoDeBarras;
				vendaNova.DescricaoCodBarras = model.DescricaoCodBarrras;

				bool sucesso = _serviceVendas.Editar(vendaNova);

				return Json(new
				{
					Ok = sucesso,
					Title = sucesso ? "Sucesso" : "Erro",
					Message = sucesso ? "Sucesso ao editar venda!" : "Erro ao editar a venda!",
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

		[HttpGet("Visualizar")]
        public IActionResult Visualizar(int id)
        {
            var venda = _serviceVendas.ObterPorIdVendas(id);
            
            return View(venda);
        }

        [HttpGet("Copiar")]
        public IActionResult Copiar(int id) 
        {
			ViewBag.Clientes = _serviceClientes.Listar().ToList();
			ViewBag.Produtos = _serviceProdutos.Listar().ToList();
			var venda = _serviceVendas.ObterPorIdVendas(id);
			return View(venda);
        }

        [HttpGet("Editar")]
        public IActionResult Editar(int id)
        {
			ViewBag.Clientes = _serviceClientes.Listar().ToList();
			ViewBag.Produtos = _serviceProdutos.Listar().ToList();
			var venda = _serviceVendas.ObterPorIdVendas(id);
			return View(venda);
        }

        [HttpGet("TrocarStatus")]
        public IActionResult TrocarStatus(int idVenda, int status)
        {
            try
            {
				var venda = _serviceVendas.ObterPorIdVendas(idVenda);

				venda.Status = status;
				bool sucesso = _serviceVendas.Editar(venda);

				return Json(new
				{
					Ok = sucesso,
					Title = sucesso ? "Sucesso" : "Erro",
					Message = sucesso ? "Sucesso ao mudar status da venda!" : "Erro ao mudar status da venda!",
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
	}
}
