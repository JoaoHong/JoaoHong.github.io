using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Interface.IService;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Service
{
    public class ServiceVendas : IServiceVendas
    {
        private readonly IRepositoryVendas _repositoryVendas;

        public ServiceVendas(IRepositoryVendas repositoryVendas)
        {
            _repositoryVendas = repositoryVendas;
        }

        public Vendas ObterPorIdVendas(int id)
        {
            return _repositoryVendas.FirstOrDefault(x => x.Id == id, includeProperties: "IdOrcamentoNavigation,IdProdutoNavigation,IdVendedorNavigation,IdUsuarioNavigation,IdOrcamentoNavigation.IdCompradorNavigation");
        }

        public bool Adicionar(Vendas entity)
        {
            return _repositoryVendas.Insert(entity);
        }

        public bool Editar(Vendas entity)
        {
            return _repositoryVendas.Update(entity);
        }

        public bool Deletar(int id)
        {
            return _repositoryVendas.Delete(id);
        }

        public IEnumerable<Vendas> Listar()
        {
            return _repositoryVendas.Get(includeProperties: "IdOrcamentoNavigation,IdProdutoNavigation,IdVendedorNavigation,IdUsuarioNavigation,IdOrcamentoNavigation.IdCompradorNavigation");
        }

		public IEnumerable<Vendas> ListarPorIdOrcamento(int idOrcamento)
		{
			return _repositoryVendas.Get(x => x.IdOrcamento == idOrcamento,includeProperties: "IdOrcamentoNavigation,IdProdutoNavigation,IdVendedorNavigation,IdUsuarioNavigation,,IdOrcamentoNavigation.IdCompradorNavigation");
		}

		public Vendas LastOS()
        {
			return _repositoryVendas.Get(includeProperties: "IdOrcamentoNavigation,IdProdutoNavigation,IdVendedorNavigation,IdUsuarioNavigation,IdOrcamentoNavigation.IdCompradorNavigation").OrderByDescending(x => x.Id).FirstOrDefault(); ;
        }

        public Vendas ObterPorIdVendedor(int IdVendedor)
        {
            return _repositoryVendas.Get(x => x.IdVendedor == IdVendedor, includeProperties: "IdOrcamentoNavigation,IdProdutoNavigation,IdVendedorNavigation,IdUsuarioNavigation,IdOrcamentoNavigation.IdCompradorNavigation").FirstOrDefault();
        }

        public Vendas ObterPorIdOrcamento(int IdOrcamento)
        {
            return _repositoryVendas.Get(x => x.IdOrcamento == IdOrcamento, includeProperties: "IdOrcamentoNavigation,IdProdutoNavigation,IdVendedorNavigation,IdUsuarioNavigation,IdOrcamentoNavigation.IdCompradorNavigation").FirstOrDefault();
        }

        public IEnumerable<Vendas> ObterPorOrcamentoAprovRecus(int idOrcamento)
        {
			return _repositoryVendas.Get(x => x.IdOrcamento == idOrcamento && x.Status == 0  , includeProperties: "IdOrcamentoNavigation,IdProdutoNavigation,IdVendedorNavigation,IdUsuarioNavigation,IdOrcamentoNavigation.IdCompradorNavigation");
		}
    }
}
