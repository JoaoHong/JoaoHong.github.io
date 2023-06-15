using ConyGreen.DAO.Repository;
using VascoVasconcellos.DAO.AppDbContext;
using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Repository
{
    public class RepositoryLogAcesso : Repository<LogAcesso, MySqlDbContext>, IRepositoryLogAcesso
    {
        public RepositoryLogAcesso() : base() { }
        public RepositoryLogAcesso(MySqlDbContext context) : base(context) { }
    }
}
