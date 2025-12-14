using LMS_Data_Access_Layer.Data;
using LMS_Data_Access_Layer.IRepository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace LMS_Business_Layer.Repository
{
    public class GenericRepo<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        protected readonly LMS_CMS_Context _Context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepo(LMS_CMS_Context context)
        {
            _Context = context;
            _dbSet = _Context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            _dbSet.AddRange(entities);
        }

        public async Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.CountAsync(predicate);
        }

        public void Delete(long id)
        {
            TEntity obj = _dbSet.Find(id);
            _dbSet.Remove(obj);
        }

        public async Task DeleteAsync(long id)
        {
            TEntity obj = await _dbSet.FindAsync(id);
            if (obj != null)
            {
                _dbSet.Remove(obj);
            }
        }
        public List<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.Where(predicate).ToList();
        }

        public async Task<List<TEntity>> FindByAsync<T>(Expression<Func<TEntity, bool>> predicate)
        {
            return await _dbSet.Where(predicate).ToListAsync();
        }

        public TEntity First_Or_Default(Expression<Func<TEntity, bool>> predicate)
        {
            return _dbSet.FirstOrDefault(predicate);
        }

        public TEntity Last_Or_Default<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy)
        {
            return _dbSet
           .Where(predicate)
           .OrderByDescending(orderBy)
           .FirstOrDefault();
        }

        public IQueryable<TEntity> Query()
        {
            return _dbSet.AsQueryable();
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            _dbSet.RemoveRange(entities);
        }

        public void SaveChanges()
        {
            _Context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
          await _Context.SaveChangesAsync();
        }

        public List<TEntity> Select_All()
        {
            return _dbSet.ToList();
        }

        public List<TEntity> Select_All_With_Includes(params Expression<Func<TEntity, object>>[] include)
        {
            return _dbSet.ToList();
        }

        public async Task<List<TEntity>> Select_All_With_IncludesById(Expression<Func<TEntity, bool>> predicate, params Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>[] includes)
        {
            IQueryable<TEntity> query = _dbSet;

            foreach (var include in includes)
            {
                query = include(query);
            }

            return await query.Where(predicate).ToListAsync();
        }
   

        public IQueryable<TEntity> Select_All_With_IncludesById_Pagination(Expression<Func<TEntity, bool>> filter, params Func<IQueryable<TEntity>, IQueryable<TEntity>>[] includes)
        {

          IQueryable<TEntity> query = _dbSet.Where(filter);
            foreach (var include in includes)
            {
                query = include(query);
            }
            return query;
        }

        public TEntity Select_By_Id(params object[] keyValues)
        {
            
            return  _dbSet.Find(keyValues);
        }

        public async Task<TEntity> Select_By_IdAsync(params object[] keyValues)
        {
           
            return await _dbSet.FindAsync(keyValues).AsTask();
        }

        public void Update(TEntity entity)
        {
            _Context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }

        public void UpdateRange(IEnumerable<TEntity> entities)
        {
           
            foreach (var entity in entities)
            {
                _Context.Entry(entity).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            }
        }
    }
}
