using ConyGreen.DAO.DbContext;
using ConyGreen.DAO.Models;

namespace ConyGreen.DAO.IRepository
{
	public interface IRepositoryLogAcesso : IRepository<LogAcesso, MySqlDbContext>
	{
	}
}
