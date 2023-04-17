using ConyGreen.DAO.DbContext;
using ConyGreen.DAO.IRepository;
using ConyGreen.DAO.Models;

namespace ConyGreen.DAO.Repository
{
	public class RepositoryUsuario : Repository<Usuario, MySqlDbContext>, IRepositoryUsuario
	{
		public RepositoryUsuario() : base() { }
		public RepositoryUsuario(MySqlDbContext context) : base(context) { }
	}
}
