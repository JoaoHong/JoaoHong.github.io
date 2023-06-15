using VascoVasconcellos.DAO.AppDbContext;
using VascoVasconcellos.DAO.Inteface.IRepository;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Interface.IRepository
{
    public interface IRepositoryClientes : IRepository<Clientes, MySqlDbContext>
    {
    }
}
