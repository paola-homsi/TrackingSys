using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Service.Contracts;
using TrackingSystem.Repository;
using TrackingSystem.DAL.Contracts;
using TrackingSystem.Model.Entities;

namespace TrackingSystem.Service.Implementations
{
    public class VehicleService : IVehicleService
    {
        IUnitOfWork unitOfWork;
        IVehicleRepository vehicleRepostitory;
        IVehicleStatusRepository VehicleStatusReporsitory;

        public VehicleService(IUnitOfWork unitOfWork,
            IVehicleRepository vehicleRepostitory,
            IVehicleStatusRepository vehicleStatusRepository)
        {
            this.unitOfWork = unitOfWork;
            this.vehicleRepostitory = vehicleRepostitory;
            this.VehicleStatusReporsitory = vehicleStatusRepository;
        }

        public List<Vehicle> GetVehicles()
        {
            return vehicleRepostitory.GetAll().ToList();
        }

        public List<Vehicle> GetVehicleWithSpecificStatus(int status)
        {
            return vehicleRepostitory.GetVehiclesWithSpecificStatus(status);
        }
        public List<Vehicle> GetVehicleWithSpecificCustomer(int status)
        {
            return vehicleRepostitory.GetVehiclesWithSpecificCustomer(status);
        }
    }
}
