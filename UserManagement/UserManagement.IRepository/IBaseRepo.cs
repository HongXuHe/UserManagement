using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.IRepository
{
    public interface IBaseRepo<TEntity> where TEntity : class, new()
    {
        /// <summary>
        /// create entity
        /// </summary>
        /// <param name="entity">entity</param>
        void Create(TEntity entity);

        /// <summary>
        /// create list of entities
        /// </summary>
        /// <param name="entities">entity list</param>
        void Create(List<TEntity> entities);


        /// <summary>
        /// edit entity
        /// </summary>
        /// <param name="entity">entity to edit</param>
        void Edit(TEntity entity);

        /// <summary>
        /// delete entity(soft)
        /// </summary>
        /// <param name="entity">entity to delete</param>
        void Delete(TEntity entity);

        /// <summary>
        /// delete entity by condition
        /// </summary>
        /// <param name="expression">expression</param>
        void Delete(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// Get entity list
        /// </summary>
        /// <param name="expression">condition</param>
        /// <returns></returns>
        IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> expression);

        /// <summary>
        /// get paged list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="whereLambda">condition</param>
        /// <param name="orderByLambda">orderby column name</param>
        /// <param name="isAsc">is asc</param>
        /// <param name="pageIndex">pageIndex</param>
        /// <param name="pageSize">pageSize</param>
        /// <returns></returns>
        IQueryable<TEntity> GetPagedList<T>(Expression<Func<TEntity, bool>> whereLambda,
            Expression<Func<TEntity, T>> orderByLambda, bool isAsc = true, int pageIndex = 0, int pageSize = 10);

        /// <summary>
        /// Find single entity
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>

        TEntity FindSingle(Expression<Func<TEntity, bool>> whereLambda);

        /// <summary>
        /// is entity exists
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        bool Exists(Expression<Func<TEntity, bool>> whereLambda);

        /// <summary>
        /// get count of condition based entity list
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        int GetCount(Expression<Func<TEntity, bool>> whereLambda);

    }
}
