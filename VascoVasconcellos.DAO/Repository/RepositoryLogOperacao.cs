using ConyGreen.DAO.Repository;
using VascoVasconcellos.DAO.AppDbContext;
using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Repository
{
    public class RepositoryLogOperacao : Repository<LogOperacao, MySqlDbContext>, IRepositoryLogOperacao
    {
        public RepositoryLogOperacao() : base() { }
        public RepositoryLogOperacao(MySqlDbContext context) : base(context) { }
    }
}
