
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.DAL.Contracts;
using TrackingSystem.Model;

namespace TrackingSystem.DAL.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {
        private TrackingVehiclesContext dataContext;
        private readonly IDatabaseFactory databaseFactory;

        public TrackingVehiclesContext DataContext {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }
        public UnitOfWork(IDatabaseFactory databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }
    }
}
