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
    public class VehicleStatusRepository: Repository<Vehicle_Status_Log>, IVehicleStatusRepository
    {
        private TrackingVehiclesContext dataContext;
        protected IDatabaseFactory databaseFactory { get; private set; }
        public VehicleStatusRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
            this.databaseFactory = databaseFactory;
        }
        protected TrackingVehiclesContext DataContext
        {
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }
        
    }
    public interface IVehicleStatusRepository: IRepository<Vehicle_Status_Log>
    {
        
    }
}

