using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Interface.IService
{
    public interface IServiceOrcamentos
    {
        Orcamentos ObterPorIdOrcamentos(int OrcamentosId);

        bool Adicionar(Orcamentos entity);

        bool Editar(Orcamentos entity);

        bool Deletar(int id);

        IEnumerable<Orcamentos> Listar();

        IEnumerable<Orcamentos> ObterPorIdVendedor(int idVendedor);

		IEnumerable <Orcamentos> ObterOrcAtivo(int idVendedor);

        Orcamentos ObterLastOrcPorVendedor(int IdVendedor);

	}
}
