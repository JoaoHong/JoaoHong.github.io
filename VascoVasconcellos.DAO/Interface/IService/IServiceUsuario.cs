using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Interface.IService
{
    public interface IServiceUsuario
    {
        Usuario ObterPorIdUsuario(int UsuarioId);

        bool Adicionar(Usuario entity);

        bool Editar(Usuario entity);

        bool Deletar(int id);

        IEnumerable<Usuario> Listar();
        Usuario ObterPorIdAspNet(string idAsp);

    }
}
