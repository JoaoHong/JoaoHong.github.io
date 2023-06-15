using ConyGreen.DAO.Repository;
using VascoVasconcellos.DAO.AppDbContext;
using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Repository
{
    public class RepositoryProdutosColunas : Repository<ProdutosColunas, MySqlDbContext>, IRepositoryProdutosColunas
    {
        public RepositoryProdutosColunas() : base() { }
        public RepositoryProdutosColunas(MySqlDbContext context) : base(context) { }
    }
}
