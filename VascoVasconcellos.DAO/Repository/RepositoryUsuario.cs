using ConyGreen.DAO.Repository;
using VascoVasconcellos.DAO.AppDbContext;
using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Repository
{
    public class RepositoryUsuario : Repository<Usuario, MySqlDbContext>, IRepositoryUsuario
    {
        public RepositoryUsuario() : base() { }
        public RepositoryUsuario(MySqlDbContext context) : base(context) { }
    }
}
