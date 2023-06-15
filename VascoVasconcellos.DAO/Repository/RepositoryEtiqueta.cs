using ConyGreen.DAO.Repository;
using VascoVasconcellos.DAO.AppDbContext;
using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Repository
{
    public class RepositoryEtiqueta : Repository<Etiqueta, MySqlDbContext>, IRepositoryEtiqueta
    {
        public RepositoryEtiqueta() : base() { }
        public RepositoryEtiqueta(MySqlDbContext context) : base(context) { }
    }
}
