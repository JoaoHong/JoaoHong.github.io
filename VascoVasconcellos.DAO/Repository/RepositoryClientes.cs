using ConyGreen.DAO.Repository;
using VascoVasconcellos.DAO.AppDbContext;
using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Repository
{
    public class RepositoryClientes : Repository<Clientes, MySqlDbContext>, IRepositoryClientes
    {
        public RepositoryClientes() : base() { }
        public RepositoryClientes(MySqlDbContext context) : base(context) { }
    }
}
