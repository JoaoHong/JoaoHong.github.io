using ConyGreen.DAO.IRepository;
using ConyGreen.DAO.IService;
using ConyGreen.DAO.Models;

namespace ConyGreen.DAO.Service
{
	public class ServiceRomaneio : IServiceRomaneio
	{
		private readonly IRepositoryRomaneio _repositoryRomaneio;

		public ServiceRomaneio(IRepositoryRomaneio repositoryRomaneio)
		{
			_repositoryRomaneio = repositoryRomaneio;
		}

		public Romaneio ObterPorIdRomaneio(int id)
		{
			return _repositoryRomaneio.FirstOrDefault(x => x.Id == id);
		}

		public Romaneio ObterPorCorte(int corte)
		{
			return _repositoryRomaneio.FirstOrDefault(x => x.Corte == corte);
		}

		public bool Adicionar(Romaneio entity)
		{
			return _repositoryRomaneio.Insert(entity);
		}

		public bool Editar(Romaneio entity)
		{
			return _repositoryRomaneio.Update(entity);
		}

		public bool Deletar(int id)
		{
			return _repositoryRomaneio.Delete(id);
		}

		public IEnumerable<Romaneio> Listar() 
		{
			return _repositoryRomaneio.Get();
		}

		public Romaneio[] ObterTodos(string includeProperties = "", bool noTracking = true)
		{
			throw new NotImplementedException();
		}

		public bool AdicionarTodos(IEnumerable<Romaneio> entities)
		{
			throw new NotImplementedException();
		}

		public bool EditarTodos(IEnumerable<Romaneio> entities)
		{
			throw new NotImplementedException();
		}

		public Romaneio ObterPorId(int id, string includeProperties = "")
		{
			throw new NotImplementedException();
		}
	}
}
