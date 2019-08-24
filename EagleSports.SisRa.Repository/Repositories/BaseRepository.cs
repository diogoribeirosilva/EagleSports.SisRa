using EagleSports.SisRa.Domain.Interfaces;
using EagleSports.SisRa.Repository.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EagleSports.SisRa.Repository.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly SisRaContext _sisRaContext;

        public BaseRepository(SisRaContext sisRaContext)
        {
            _sisRaContext = sisRaContext;
        }
        public void Adicionar(TEntity entity)
        {
            _sisRaContext.Set<TEntity>().Add(entity);
            _sisRaContext.SaveChanges();
        }

        public void Atualizar(TEntity entity)
        {
            _sisRaContext.Set<TEntity>().Update(entity);
            _sisRaContext.SaveChanges();
        }
        public TEntity ObterPorId(int id)
        {
            return _sisRaContext.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> ObterTodos()
        {
            return _sisRaContext.Set<TEntity>().ToList();
        }

        public void Remover(TEntity entity)
        {
            _sisRaContext.Remove(entity);
            _sisRaContext.SaveChanges();
        }
        public void Dispose()
        {
            _sisRaContext.Dispose();
        }
    }
}
