using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Interface.IService;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Service
{
    public class ServiceOrcamentos : IServiceOrcamentos
    {
        private readonly IRepositoryOrcamentos _repositoryOrcamentos;

        public ServiceOrcamentos(IRepositoryOrcamentos repositoryOrcamentos)
        {
            _repositoryOrcamentos = repositoryOrcamentos;
        }

        public Orcamentos ObterPorIdOrcamentos(int id)
        {
            return _repositoryOrcamentos.FirstOrDefault(x => x.Id == id);
        }

        public bool Adicionar(Orcamentos entity)
        {
            return _repositoryOrcamentos.Insert(entity);
        }

        public bool Editar(Orcamentos entity)
        {
            return _repositoryOrcamentos.Update(entity);
        }

        public bool Deletar(int id)
        {
            return _repositoryOrcamentos.Delete(id);
        }

        public IEnumerable<Orcamentos> Listar()
        {
            return _repositoryOrcamentos.Get(includeProperties: "IdVendedorNavigation,IdCompradorNavigation");
        }

        public Orcamentos[] ObterTodos(string includeProperties = "", bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public bool AdicionarTodos(IEnumerable<Orcamentos> entities)
        {
            throw new NotImplementedException();
        }

        public bool EditarTodos(IEnumerable<Orcamentos> entities)
        {
            throw new NotImplementedException();
        }

        public Orcamentos ObterPorId(int id, string includeProperties = "")
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Orcamentos> ObterPorIdVendedor(int IdVendedor)
        {
            return _repositoryOrcamentos.Get(x => x.IdVendedor == IdVendedor);
        }

		public IEnumerable<Orcamentos> ObterOrcAtivo(int IdVendedor)
        {
            return _repositoryOrcamentos.Get(x => x.IdVendedor == IdVendedor && x.Status == true, includeProperties: "IdVendedorNavigation");
        }

        public Orcamentos ObterLastOrcPorVendedor(int IdVendedor)
        {
            return _repositoryOrcamentos.Get(x => x.IdVendedor == IdVendedor).OrderByDescending(x => x.Id).FirstOrDefault(); 
        }
    }
}
