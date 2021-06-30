using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using VTorres.Business.Core.Data;
using VTorres.Business.Core.Models;
using VTorres.Infra.Data.Context;

namespace VTorres.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly DataContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository()
        {
            Db = new DataContext();
            DbSet = Db.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }

        public virtual async Task<TEntity> ObterPorId(Guid id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual async Task<List<TEntity>> ObterTodos()
        {
            return await DbSet.ToListAsync();
        }

        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }

        public virtual async Task Atualizar(TEntity entity)
        {
            Db.Entry(entity).State = EntityState.Modified;
            await SaveChanges();
        }

        public virtual async Task Remover(Guid id)
        {
            Db.Entry(new TEntity { Id = id }).State = EntityState.Deleted;
            await SaveChanges();
        }

        public virtual async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
