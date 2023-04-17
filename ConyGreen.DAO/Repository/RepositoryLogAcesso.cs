using ConyGreen.DAO.DbContext;
using ConyGreen.DAO.IRepository;
using ConyGreen.DAO.Models;

namespace ConyGreen.DAO.Repository
{
	public class RepositoryLogAcesso : Repository<LogAcesso, MySqlDbContext>, IRepositoryLogAcesso
	{
		public RepositoryLogAcesso() : base() { }
		public RepositoryLogAcesso(MySqlDbContext context) : base(context) { }
	}
}
