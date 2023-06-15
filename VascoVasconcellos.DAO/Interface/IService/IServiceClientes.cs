using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Interface.IService
{
    public interface IServiceClientes
    {
        Clientes ObterPorIdClientes(int ClientesId);

        bool Adicionar(Clientes entity);

        bool Editar(Clientes entity);

        bool Deletar(int id);

        IEnumerable<Clientes> Listar();

    }
}
