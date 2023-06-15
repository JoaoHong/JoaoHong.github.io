using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Interface.IService;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Service
{
    public class ServiceProdutosColunas : IServiceProdutosColunas
    {
        private readonly IRepositoryProdutosColunas _repositoryProdutosColunas;

        public ServiceProdutosColunas(IRepositoryProdutosColunas repositoryProdutosColunas)
        {
            _repositoryProdutosColunas = repositoryProdutosColunas;
        }

        public ProdutosColunas ObterPorIdProdutos(int IdProduto)
        {
            return _repositoryProdutosColunas.FirstOrDefault(x => x.IdProduto == IdProduto);
        }

        public bool Adicionar(ProdutosColunas entity)
        {
            return _repositoryProdutosColunas.Insert(entity);
        }

        public bool Editar(ProdutosColunas entity)
        {
            return _repositoryProdutosColunas.Update(entity);
        }

        public bool Deletar(int id)
        {
            return _repositoryProdutosColunas.Delete(id);
        }

        public IEnumerable<ProdutosColunas> Listar()
        {
            return _repositoryProdutosColunas.Get();
        }

        public ProdutosColunas[] ObterTodos(string includeProperties = "", bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public bool AdicionarTodos(IEnumerable<ProdutosColunas> entities)
        {
            throw new NotImplementedException();
        }

        public bool EditarTodos(IEnumerable<ProdutosColunas> entities)
        {
            throw new NotImplementedException();
        }

        public ProdutosColunas ObterPorId(int id, string includeProperties = "")
        {
            throw new NotImplementedException();
        }
    }
}
