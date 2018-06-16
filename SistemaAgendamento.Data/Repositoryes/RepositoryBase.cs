using Microsoft.EntityFrameworkCore;
using SistemaAgendamento.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace SistemaAgendamento.Data.Repositoryes
{
    public class RepositoryBase<TEntity> : IDisposable where TEntity : class
    {
        public DataContext dbContext = new DataContext();

        public DbSet<TEntity> TableContext { get; set; }

        public RepositoryBase()
        {
            TableContext = dbContext.Set<TEntity>();
        }

        public TEntity Select(int id)
        {
            return dbContext.Set<TEntity>().Find(id);
        }

        public List<TEntity> SelectAll()
        {
            return dbContext.Set<TEntity>().ToList();
        }

        public void Insert(TEntity entity)
        {
            dbContext.Set<TEntity>().Add(entity);
            dbContext.SaveChanges();
        }

        public void InsertAll(List<TEntity> entities)
        {
            foreach (var item in entities)
            {
                dbContext.Set<TEntity>().Add(item);
            }
            dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            dbContext.Set<TEntity>().Remove(Select(id));
            dbContext.SaveChanges();
        }

        public void Delete(TEntity entity)
        {
            dbContext.Set<TEntity>().Remove(entity);
            dbContext.SaveChanges();
        }

        public void Delete(List<TEntity> entities)
        {
            foreach (var item in entities)
            {
                dbContext.Set<TEntity>().Remove(item);
            }
            dbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            dbContext.Entry(entity).State = EntityState.Modified;
            dbContext.SaveChanges();
        }

        public void Update(List<TEntity> entities)
        {
            foreach (var item in entities)
            {
                dbContext.Entry(item).State = EntityState.Modified;
            }
            dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
}
