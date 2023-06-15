using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Interface.IService;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Service
{
    public class ServiceProdutos : IServiceProdutos
    {
        private readonly IRepositoryProdutos _repositoryProdutos;

        public ServiceProdutos(IRepositoryProdutos repositoryProdutos)
        {
            _repositoryProdutos = repositoryProdutos;
        }

        public Produtos ObterPorIdProdutos(int id)
        {
            return _repositoryProdutos.FirstOrDefault(x => x.Id == id);
        }

        public bool Adicionar(Produtos entity)
        {
            return _repositoryProdutos.Insert(entity);
        }

        public bool Editar(Produtos entity)
        {
            return _repositoryProdutos.Update(entity);
        }

        public bool Deletar(int id)
        {
            return _repositoryProdutos.Delete(id);
        }

        public IEnumerable<Produtos> Listar()
        {
            return _repositoryProdutos.Get();
        }

        public Produtos[] ObterTodos(string includeProperties = "", bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public bool AdicionarTodos(IEnumerable<Produtos> entities)
        {
            throw new NotImplementedException();
        }

        public bool EditarTodos(IEnumerable<Produtos> entities)
        {
            throw new NotImplementedException();
        }

        public Produtos ObterPorId(int id, string includeProperties = "")
        {
            throw new NotImplementedException();
        }
    }
}
