using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Interface.IService;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Service
{
    public class ServiceLogErro : IServiceLogErro
    {
        private readonly IRepositoryLogErro _repositoryLogErro;

        public ServiceLogErro(IRepositoryLogErro repositoryLogErro)
        {
            _repositoryLogErro = repositoryLogErro;
        }

        public LogErro ObterPorIdLogErro(int id)
        {
            return _repositoryLogErro.FirstOrDefault(x => x.Id == id);
        }

        public bool Adicionar(LogErro entity)
        {
            return _repositoryLogErro.Insert(entity);
        }

        public bool Editar(LogErro entity)
        {
            return _repositoryLogErro.Update(entity);
        }

        public bool Deletar(int id)
        {
            return _repositoryLogErro.Delete(id);
        }

        public IEnumerable<LogErro> Listar()
        {
            return _repositoryLogErro.Get();
        }

        public LogErro[] ObterTodos(string includeProperties = "", bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public bool AdicionarTodos(IEnumerable<LogErro> entities)
        {
            throw new NotImplementedException();
        }

        public bool EditarTodos(IEnumerable<LogErro> entities)
        {
            throw new NotImplementedException();
        }

        public LogErro ObterPorId(int id, string includeProperties = "")
        {
            throw new NotImplementedException();
        }
    }
}
