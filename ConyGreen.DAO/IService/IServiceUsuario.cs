using ConyGreen.DAO.Models;

namespace ConyGreen.DAO.IService
{
	public interface IServiceUsuario : IService<Usuario>
	{
		Usuario ObterPorIdUsuario(int UsuarioId);

		Usuario ObterPorIdAspNet(string idAsp);

		bool Adicionar(Usuario entity);

		bool Editar(Usuario entity);

		bool Deletar(int id);

		IEnumerable<Usuario> Listar();
	}
}
