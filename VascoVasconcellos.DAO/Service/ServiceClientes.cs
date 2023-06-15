using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Interface.IService;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Service
{
    public class ServiceClientes : IServiceClientes
    {
        private readonly IRepositoryClientes _repositoryClientes;

        public ServiceClientes(IRepositoryClientes repositoryClientes)
        {
            _repositoryClientes = repositoryClientes;
        }

        public Clientes ObterPorIdClientes(int id)
        {
            return _repositoryClientes.FirstOrDefault(x => x.Id == id);
        }

        public bool Adicionar(Clientes entity)
        {
            return _repositoryClientes.Insert(entity);
        }

        public bool Editar(Clientes entity)
        {
            return _repositoryClientes.Update(entity);
        }

        public bool Deletar(int id)
        {
            return _repositoryClientes.Delete(id);
        }

        public IEnumerable<Clientes> Listar()
        {
            return _repositoryClientes.Get();
        }

        public Clientes[] ObterTodos(string includeProperties = "", bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public bool AdicionarTodos(IEnumerable<Clientes> entities)
        {
            throw new NotImplementedException();
        }

        public bool EditarTodos(IEnumerable<Clientes> entities)
        {
            throw new NotImplementedException();
        }

        public Clientes ObterPorId(int id, string includeProperties = "")
        {
            throw new NotImplementedException();
        }
    }
}
