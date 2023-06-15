using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Interface.IService
{
    public interface IServiceLogOperacao
    {
        LogOperacao ObterPorIdLogOperacao(int LogOperacaoId);

        bool Adicionar(LogOperacao entity);

        bool Editar(LogOperacao entity);

        bool Deletar(int id);

        IEnumerable<LogOperacao> Listar();

    }
}
