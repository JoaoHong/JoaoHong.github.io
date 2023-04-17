using ConyGreen.DAO.Models;

namespace ConyGreen.DAO.IService
{
	public interface IServiceLogAcesso : IService<LogAcesso>
	{
		LogAcesso ObterPorIdLogAcesso(int LogAcessoId);

		bool Adicionar(LogAcesso entity);

		bool Editar(LogAcesso entity);

		bool Deletar(int id);

		IEnumerable<LogAcesso> Listar();
	}
}
