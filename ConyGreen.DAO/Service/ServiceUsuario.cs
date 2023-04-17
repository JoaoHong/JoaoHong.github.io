using ConyGreen.DAO.IRepository;
using ConyGreen.DAO.IService;
using ConyGreen.DAO.Models;

namespace ConyGreen.DAO.Service
{
	public class ServiceUsuario : IServiceUsuario
	{
		private readonly IRepositoryUsuario _repositoryUsuario;

		public ServiceUsuario(IRepositoryUsuario repositoryUsuario)
		{
			_repositoryUsuario = repositoryUsuario;
		}

		public Usuario ObterPorIdUsuario(int id)
		{
			return _repositoryUsuario.FirstOrDefault(x => x.Id == id);
		}

		public Usuario ObterPorIdAspNet(string idAsp)
		{
			return _repositoryUsuario.FirstOrDefault(x => x.IdAspNetUser == idAsp);
		}

		public bool Adicionar(Usuario entity)
		{
			return _repositoryUsuario.Insert(entity);
		}

		public bool Editar(Usuario entity)
		{
			return _repositoryUsuario.Update(entity);
		}

		public bool Deletar(int id)
		{
			return _repositoryUsuario.Delete(id);
		}

		public IEnumerable<Usuario> Listar() 
		{
			return _repositoryUsuario.Get();
		}

		public Usuario[] ObterTodos(string includeProperties = "", bool noTracking = true)
		{
			throw new NotImplementedException();
		}

		public bool AdicionarTodos(IEnumerable<Usuario> entities)
		{
			throw new NotImplementedException();
		}

		public bool EditarTodos(IEnumerable<Usuario> entities)
		{
			throw new NotImplementedException();
		}

		public Usuario ObterPorId(int id, string includeProperties = "")
		{
			throw new NotImplementedException();
		}
	}
}
