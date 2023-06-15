using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Interface.IService
{
    public interface IServiceEtiqueta
    {
        Etiqueta ObterPorIdEtiqueta(int EtiquetaId);

        bool Adicionar(Etiqueta entity);

        bool Editar(Etiqueta entity);

        bool Deletar(int id);

        IEnumerable<Etiqueta> Listar();

    }
}
