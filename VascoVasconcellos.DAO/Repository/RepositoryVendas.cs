using ConyGreen.DAO.Repository;
using VascoVasconcellos.DAO.AppDbContext;
using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Repository
{
    public class RepositoryVendas : Repository<Vendas, MySqlDbContext>, IRepositoryVendas
    {
        public RepositoryVendas() : base() { }
        public RepositoryVendas(MySqlDbContext context) : base(context) { }
    }
}
