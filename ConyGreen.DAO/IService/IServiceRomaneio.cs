using ConyGreen.DAO.Models;

namespace ConyGreen.DAO.IService
{
	public interface IServiceRomaneio : IService<Romaneio>
	{
		Romaneio ObterPorIdRomaneio(int romaneioId);

		bool Adicionar(Romaneio entity);

		bool Editar(Romaneio entity);

		bool Deletar(int id);

		IEnumerable<Romaneio> Listar();

		Romaneio ObterPorCorte(int corte);
	}
}
