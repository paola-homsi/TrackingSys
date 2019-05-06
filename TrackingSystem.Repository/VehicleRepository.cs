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
    public class VehicleRepository : Repository<Vehicle>, IVehicleRepository
    {
        private TrackingVehiclesContext dataContext;
        protected IDatabaseFactory databaseFactory { get; private set; }
        public VehicleRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
            this.databaseFactory = databaseFactory;
            DataContext = this.databaseFactory.Get();
        }
        protected TrackingVehiclesContext DataContext
        {
            set { }
            get { return dataContext ?? (dataContext = databaseFactory.Get()); }
        }
        List<Vehicle> IVehicleRepository.GetVehiclesWithSpecificStatus(int StatusID)
        {
            return GetMany(c => c.Status_Id == StatusID).ToList();
        }
        List<Vehicle> IVehicleRepository.GetVehiclesWithSpecificCustomer(int CustomerID)
        {
            return GetMany(c => c.CustomerID == CustomerID).ToList();
        }

    }
    public interface IVehicleRepository : IRepository<Vehicle>
    {
        List<Vehicle> GetVehiclesWithSpecificStatus(int StatusID);
        List<Vehicle> GetVehiclesWithSpecificCustomer(int CustomerID);
    }
}
