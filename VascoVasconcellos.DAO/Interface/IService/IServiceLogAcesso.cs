using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Interface.IService
{
    public interface IServiceLogAcesso
    {
        LogAcesso ObterPorIdLogAcesso(int LogAcessoId);

        bool Adicionar(LogAcesso entity);

        bool Editar(LogAcesso entity);

        bool Deletar(int id);

        IEnumerable<LogAcesso> Listar();

    }
}
