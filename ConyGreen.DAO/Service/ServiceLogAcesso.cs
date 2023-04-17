using ConyGreen.DAO.IRepository;
using ConyGreen.DAO.IService;
using ConyGreen.DAO.Models;

namespace ConyGreen.DAO.Service
{
	public class ServiceLogAcesso : IServiceLogAcesso
	{
		private readonly IRepositoryLogAcesso _repositoryLogAcesso;

		public ServiceLogAcesso(IRepositoryLogAcesso repositoryLogAcesso)
		{
			_repositoryLogAcesso = repositoryLogAcesso;
		}

		public LogAcesso ObterPorIdLogAcesso(int id)
		{
			return _repositoryLogAcesso.FirstOrDefault(x => x.Id == id);
		}

		public bool Adicionar(LogAcesso entity)
		{
			return _repositoryLogAcesso.Insert(entity);
		}

		public bool Editar(LogAcesso entity)
		{
			return _repositoryLogAcesso.Update(entity);
		}

		public bool Deletar(int id)
		{
			return _repositoryLogAcesso.Delete(id);
		}

		public IEnumerable<LogAcesso> Listar() 
		{
			return _repositoryLogAcesso.Get();
		}

		public LogAcesso[] ObterTodos(string includeProperties = "", bool noTracking = true)
		{
			throw new NotImplementedException();
		}

		public bool AdicionarTodos(IEnumerable<LogAcesso> entities)
		{
			throw new NotImplementedException();
		}

		public bool EditarTodos(IEnumerable<LogAcesso> entities)
		{
			throw new NotImplementedException();
		}

		public LogAcesso ObterPorId(int id, string includeProperties = "")
		{
			throw new NotImplementedException();
		}
	}
}
