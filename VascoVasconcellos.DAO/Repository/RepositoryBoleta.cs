using ConyGreen.DAO.Repository;
using VascoVasconcellos.DAO.AppDbContext;
using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Repository
{
    public class RepositoryBoleta : Repository<Boleta, MySqlDbContext>, IRepositoryBoleta
    {
        public RepositoryBoleta() : base() { }
        public RepositoryBoleta(MySqlDbContext context) : base(context) { }
    }
}
