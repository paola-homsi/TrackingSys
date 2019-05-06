using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Model.Entities;
using TrackingSystem.DAL.Implementations;
using TrackingSystem.Model;
using TrackingSystem.DAL.Contracts;

namespace TrackingSystem.Repository
{
    public class ClientRepository : Repository<Customer>, IClientReporsitory
    {
        private TrackingVehiclesContext dataContext;
        protected IDatabaseFactory databaseFactory { get; private set; }
        public ClientRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }
        protected TrackingVehiclesContext DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }

    }
    public interface IClientReporsitory : IRepository<Customer>
    {

    }
}
