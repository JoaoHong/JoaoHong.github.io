using ConyGreen.DAO.DbContext;
using ConyGreen.DAO.IRepository;
using ConyGreen.DAO.Models;

namespace ConyGreen.DAO.Repository
{
	public class RepositoryRomaneio : Repository<Romaneio, MySqlDbContext>, IRepositoryRomaneio
	{
		public RepositoryRomaneio() : base() { }
		public RepositoryRomaneio(MySqlDbContext context) : base(context) { }
	}
}
