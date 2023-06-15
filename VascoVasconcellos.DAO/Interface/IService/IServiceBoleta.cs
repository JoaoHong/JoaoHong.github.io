using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Interface.IService
{
    public interface IServiceBoleta
    {
        Boleta ObterPorIdBoleta(int BoletaId);

        bool Adicionar(Boleta entity);

        bool Editar(Boleta entity);

        bool Deletar(int id);

        IEnumerable<Boleta> Listar();

    }
}
