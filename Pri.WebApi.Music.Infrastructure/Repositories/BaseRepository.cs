using Microsoft.EntityFrameworkCore;
using Pri.Oe.WebApi.Music.Infrastructure.Data;
using Pri.Oe.WebApi.Music.Core.Entities.Base;
using Pri.Oe.WebApi.Music.Core.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pri.Oe.WebApi.Music.Infrastructure.Repositories
{

    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        protected readonly MusicDbContext _dbContext;

        public BaseRepository(MusicDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual IQueryable<T> GetAll()
        {
            return _dbContext.Set<T>().AsQueryable();
        }

        public virtual async Task<IEnumerable<T>> ListAllAsync()
        {
            return await GetAll().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await GetAll().SingleOrDefaultAsync(t => t.Id.Equals(id));
        }

        public async Task<T> UpdateAsync(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> AddAsync(T entity)
        {
            _dbContext.Set<T>().Add(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }

        public async Task<T> DeleteAsync(T entity)
        {
            _dbContext.Set<T>().Remove(entity);
            await _dbContext.SaveChangesAsync();
            return entity;
        }
    }
}
