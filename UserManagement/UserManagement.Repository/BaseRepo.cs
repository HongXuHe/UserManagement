using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using UserManagement.Entity;
using UserManagement.IRepository;

namespace UserManagement.Repository
{
    public class BaseRepo<TEntity> : IBaseRepo<TEntity> where TEntity : BaseEntity, new()
    {
        private readonly UserManagementContext _context;

        public BaseRepo(UserManagementContext context)
        {
            _context = context;
        }

        /// <summary>
        /// create entity
        /// </summary>
        /// <param name="entity"></param>
        public void Create(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
        }


        /// <summary>
        /// create list of entities
        /// </summary>
        /// <param name="entities"></param>
        public void Create(List<TEntity> entities)
        {
            _context.Set<TEntity>().AddRange(entities);
        }

        /// <summary>
        /// delete entity (soft)
        /// </summary>
        /// <param name="entity"></param>

        public void Delete(TEntity entity)
        {
            entity.SoftDelete = true;
        }

        /// <summary>
        /// soft delete based on expression
        /// </summary>
        /// <param name="expression"></param>
        public void Delete(Expression<Func<TEntity, bool>> expression)
        {
            var entity = _context.Set<TEntity>().Where(expression).FirstOrDefault();
            if (entity != null)
            {
                entity.SoftDelete = true;
            }
        }

        /// <summary>
        /// edit
        /// </summary>
        /// <param name="entity"></param>
        public void Edit(TEntity entity)
        {
            _context.Entry<TEntity>(entity).State = EntityState.Modified;
        }

        /// <summary>
        /// entity exists
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>

        public bool Exists(Expression<Func<TEntity, bool>> whereLambda)
        {
            return _context.Set<TEntity>().Where(e => !e.SoftDelete).Any(whereLambda);
        }

        /// <summary>
        /// get single entity
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public virtual TEntity FindSingle(Expression<Func<TEntity, bool>> whereLambda)
        {
            return _context.Set<TEntity>().Where(e => !e.SoftDelete).FirstOrDefault(whereLambda);
        }

        /// <summary>
        /// get cound by condition
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public int GetCount(Expression<Func<TEntity, bool>> whereLambda)
        {
            return _context.Set<TEntity>().Where(whereLambda).Where(e => !e.SoftDelete).Count();
        }

        /// <summary>
        /// get conditioned list
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public IQueryable<TEntity> GetList(Expression<Func<TEntity, bool>> expression)
        {
            return _context.Set<TEntity>().Where(expression).Where(e => !e.SoftDelete);
        }

        /// <summary>
        /// get paged list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="whereLambda">condition</param>
        /// <param name="orderByLambda">orderby condition</param>
        /// <param name="isAsc">asc or desc</param>
        /// <param name="pageIndex">pageIndex</param>
        /// <param name="pageSize">pageSize</param>
        /// <returns></returns>
        public IQueryable<TEntity> GetPagedList<T>(Expression<Func<TEntity, bool>> whereLambda, Expression<Func<TEntity, T>> orderByLambda, bool isAsc = true, int pageIndex = 0, int pageSize = 10)
        {
            var list = _context.Set<TEntity>().Where(whereLambda).Where(e => !e.SoftDelete);
            if (isAsc)
            {
                list = list.OrderBy(orderByLambda);
            }
            else
            {
                list = list.OrderByDescending(orderByLambda);
            }
            list = list.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return list;
        }

        /// <summary>
        /// retrive all the table names from db
        /// </summary>
        /// <param name="whereLambda"></param>
        /// <returns></returns>
        public IQueryable<string> GetDataBaseTables(Expression<Func<string, bool>> whereLambda)
        {
            var listTable = new List<string>();
            var entityTypes = _context.Model.GetEntityTypes();
            foreach (var item in entityTypes)
            {
                listTable.Add(item.Name);
            }
            return listTable.ToList().AsQueryable().Where(whereLambda);

        }
    }
}
