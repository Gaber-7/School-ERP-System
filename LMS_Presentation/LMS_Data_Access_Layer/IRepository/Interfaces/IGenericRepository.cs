using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
 
namespace LMS_Data_Access_Layer.IRepository.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class  // Generic Repository Pattern
    {
        List<TEntity> Select_All();
        List<TEntity> Select_All_With_Includes(params Expression<Func<TEntity, Object>>[] include);   // Eager Loading تضمين علاقات داخل العلاقات
        TEntity Select_By_Id(params object[] keyValues); // Primary Key

        Task<TEntity> Select_By_IdAsync(params object[] keyValues);  // Primary Key Async

        Task<int> CountAsync(Expression<Func<TEntity, bool>> predicate);  // Count with condition Async

        void Add(TEntity entity);

        Task AddAsync(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);

        void RemoveRange(IEnumerable<TEntity> entities);
        void Delete(long id);
        Task DeleteAsync(long id);

        TEntity First_Or_Default(Expression<Func<TEntity, bool>> predicate); //Search for the first element that matches a given condition - or return null if no element is found.

        TEntity Last_Or_Default<TKey>(Expression<Func<TEntity, bool>> predicate, Expression<Func<TEntity, TKey>> orderBy); //Search for the last element that matches a given condition - or return null if no element is found.

        List<TEntity> FindBy(Expression<Func<TEntity, bool>> predicate); // All items that meet the condition are withdrawn

        Task<List<TEntity>> FindByAsync<T>(Expression<Func<TEntity, bool>> predicate); // All items that meet the condition are withdrawn Async

        IQueryable<TEntity> Query(); // To be used for complex queries with filtering, sorting, and paging


        //IQueryable<T> SelectQuery<T>(Expression<Func<T, bool>> filter) where T : class;

        //Task<List<TEntity>> Select_All_With_IncludesByIdAsync<TProperty>(Expression<Func<TEntity, bool>> predicate,
        //  params Expression<Func<TEntity, object>>[] includes);
        Task<List<TEntity>> Select_All_With_IncludesById(Expression<Func<TEntity, bool>> predicate,
               params Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>>[] includes);

        IQueryable<TEntity> Select_All_With_IncludesById_Pagination(Expression<Func<TEntity, bool>> filter,
         params Func<IQueryable<TEntity>, IQueryable<TEntity>>[] includes);


    }
}