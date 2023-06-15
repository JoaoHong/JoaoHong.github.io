using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Interface.IService
{
    public interface IServiceVendas
    {
        Vendas ObterPorIdVendas(int VendasId);

        bool Adicionar(Vendas entity);

        bool Editar(Vendas entity);

        bool Deletar(int id);

        IEnumerable<Vendas> Listar();

        IEnumerable<Vendas> ListarPorIdOrcamento(int idOrcamento);

        IEnumerable<Vendas> ObterPorOrcamentoAprovRecus(int idOrcamento);

		Vendas LastOS();
        
        Vendas ObterPorIdVendedor(int IdVendedor);

        Vendas ObterPorIdOrcamento(int IdOrcamento);

    }
}
