using VascoVasconcellos.DAO.Interface.IRepository;
using VascoVasconcellos.DAO.Interface.IService;
using VascoVasconcellos.DAO.Models;

namespace VascoVasconcellos.DAO.Service
{
    public class ServiceEtiqueta : IServiceEtiqueta
    {
        private readonly IRepositoryEtiqueta _repositoryEtiqueta;

        public ServiceEtiqueta(IRepositoryEtiqueta repositoryEtiqueta)
        {
            _repositoryEtiqueta = repositoryEtiqueta;
        }

        public Etiqueta ObterPorIdEtiqueta(int id)
        {
            return _repositoryEtiqueta.FirstOrDefault(x => x.Id == id);
        }

        public bool Adicionar(Etiqueta entity)
        {
            return _repositoryEtiqueta.Insert(entity);
        }

        public bool Editar(Etiqueta entity)
        {
            return _repositoryEtiqueta.Update(entity);
        }

        public bool Deletar(int id)
        {
            return _repositoryEtiqueta.Delete(id);
        }

        public IEnumerable<Etiqueta> Listar()
        {
            return _repositoryEtiqueta.Get();
        }

        public Etiqueta[] ObterTodos(string includeProperties = "", bool noTracking = true)
        {
            throw new NotImplementedException();
        }

        public bool AdicionarTodos(IEnumerable<Etiqueta> entities)
        {
            throw new NotImplementedException();
        }

        public bool EditarTodos(IEnumerable<Etiqueta> entities)
        {
            throw new NotImplementedException();
        }

        public Etiqueta ObterPorId(int id, string includeProperties = "")
        {
            throw new NotImplementedException();
        }
    }
}
