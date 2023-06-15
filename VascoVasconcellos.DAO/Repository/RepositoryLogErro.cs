using ConyGreen.DAO.Repository;
using VascoVasconcellos.DAO.AppDbContext;
using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Repository
{
    public class RepositoryLogErro : Repository<LogErro, MySqlDbContext>, IRepositoryLogErro
    {
        public RepositoryLogErro() : base() { }
        public RepositoryLogErro(MySqlDbContext context) : base(context) { }
    }
}
