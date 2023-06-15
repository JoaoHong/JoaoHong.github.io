using ConyGreen.DAO.Repository;
using VascoVasconcellos.DAO.AppDbContext;
using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Repository
{
    public class RepositoryProdutos : Repository<Produtos, MySqlDbContext>, IRepositoryProdutos
    {
        public RepositoryProdutos() : base() { }
        public RepositoryProdutos(MySqlDbContext context) : base(context) { }
    }
}
