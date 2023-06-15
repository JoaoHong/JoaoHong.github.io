using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Interface.IService
{
    public interface IServiceProdutosColunas
    {
        ProdutosColunas ObterPorIdProdutos(int IdProdutos);

        bool Adicionar(ProdutosColunas entity);

        bool Editar(ProdutosColunas entity);

        bool Deletar(int id);

        IEnumerable<ProdutosColunas> Listar();

    }
}
