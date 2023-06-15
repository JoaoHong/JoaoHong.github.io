using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Interface.IService;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Service
{
    public class ServiceBoleta : IServiceBoleta
    {
        private readonly IRepositoryBoleta _repositoryBoleta;

        public ServiceBoleta(IRepositoryBoleta repositoryBoleta)
        {
            _repositoryBoleta = repositoryBoleta;
        }

        public Boleta ObterPorIdBoleta(int id)
        {
            return _repositoryBoleta.FirstOrDefault(x => x.Id == id);
        }

        public bool Adicionar(Boleta entity)
        {
            return _repositoryBoleta.Insert(entity);
        }

        public bool Editar(Boleta entity)
        {
            return _repositoryBoleta.Update(entity);
        }

        public bool Deletar(int id)
        {
            return _repositoryBoleta.Delete(id);
        }

        public IEnumerable<Boleta> Listar()
        {
            return _repositoryBoleta.Get();
        }

        public Boleta[] ObterTodos(string includeProperties = "", bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public bool AdicionarTodos(IEnumerable<Boleta> entities)
        {
            throw new NotImplementedException();
        }

        public bool EditarTodos(IEnumerable<Boleta> entities)
        {
            throw new NotImplementedException();
        }

        public Boleta ObterPorId(int id, string includeProperties = "")
        {
            throw new NotImplementedException();
        }
    }
}
