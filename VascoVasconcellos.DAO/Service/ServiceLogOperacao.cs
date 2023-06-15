using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Interface.IService;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Service
{
    public class ServiceLogOperacao : IServiceLogOperacao
    {
        private readonly IRepositoryLogOperacao _repositoryLogOperacao;

        public ServiceLogOperacao(IRepositoryLogOperacao repositoryLogOperacao)
        {
            _repositoryLogOperacao = repositoryLogOperacao;
        }

        public LogOperacao ObterPorIdLogOperacao(int id)
        {
            return _repositoryLogOperacao.FirstOrDefault(x => x.Id == id);
        }

        public bool Adicionar(LogOperacao entity)
        {
            return _repositoryLogOperacao.Insert(entity);
        }

        public bool Editar(LogOperacao entity)
        {
            return _repositoryLogOperacao.Update(entity);
        }

        public bool Deletar(int id)
        {
            return _repositoryLogOperacao.Delete(id);
        }

        public IEnumerable<LogOperacao> Listar()
        {
            return _repositoryLogOperacao.Get();
        }

        public LogOperacao[] ObterTodos(string includeProperties = "", bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public bool AdicionarTodos(IEnumerable<LogOperacao> entities)
        {
            throw new NotImplementedException();
        }

        public bool EditarTodos(IEnumerable<LogOperacao> entities)
        {
            throw new NotImplementedException();
        }

        public LogOperacao ObterPorId(int id, string includeProperties = "")
        {
            throw new NotImplementedException();
        }
    }
}
