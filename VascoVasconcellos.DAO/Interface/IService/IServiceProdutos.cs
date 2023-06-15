using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Interface.IService
{
    public interface IServiceProdutos
    {
        Produtos ObterPorIdProdutos(int ProdutosId);

        bool Adicionar(Produtos entity);

        bool Editar(Produtos entity);

        bool Deletar(int id);

        IEnumerable<Produtos> Listar();

    }
}
