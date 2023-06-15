using ConyGreen.DAO.Repository;
using VascoVasconcellos.DAO.AppDbContext;
using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Repository
{
    public class RepositoryOrcamentos : Repository<Orcamentos, MySqlDbContext>, IRepositoryOrcamentos
    {
        public RepositoryOrcamentos() : base() { }
        public RepositoryOrcamentos(MySqlDbContext context) : base(context) { }
    }
}
