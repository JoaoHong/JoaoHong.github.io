using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Interface.IService
{
    public interface IServiceLogErro
    {
        LogErro ObterPorIdLogErro(int LogErroId);

        bool Adicionar(LogErro entity);

        bool Editar(LogErro entity);

        bool Deletar(int id);

        IEnumerable<LogErro> Listar();

    }
}
