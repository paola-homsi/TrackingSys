using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.DAL.Contracts;
using TrackingSystem.Model;
using System.Data.Entity;
using System.Linq.Expressions;

namespace TrackingSystem.DAL.Implementations
{
    public abstract class Repository<T> : IRepository<T> where T : class
    {
        private TrackingVehiclesContext dataContext;
        private readonly IDbSet<T> dbset;

        protected IDatabaseFactory DatabaseFactory { get; private set; }
        
        protected Repository(IDatabaseFactory databaseFactory)
        {
            DatabaseFactory = databaseFactory;
            dataContext = dataContext ?? (dataContext = DatabaseFactory.Get());
            dbset = dataContext.Set<T>();
        }
        protected TrackingVehiclesContext DataContext
        {
            get { return dataContext ?? (dataContext = DatabaseFactory.Get()); }
        }


        public virtual void Add(T Entity)
        {
            dbset.Add(Entity);
        }

        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }
        public virtual void Delete(Expression<Func<T, bool>> whereExpr)
        {
            IEnumerable<T> objects = dbset.Where(whereExpr).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }
        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }
        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }
        public virtual IEnumerable<T> GetAll()
        {
            return dbset.AsEnumerable();
        }
        public virtual T Get(Expression<Func<T, bool>> whereExp)
        {
            return dbset.Where(whereExp).FirstOrDefault();
        }
        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> whereExpr)
        {
            return dbset.Where(whereExpr).AsEnumerable();
        }
    }
}
