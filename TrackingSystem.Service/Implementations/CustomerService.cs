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
    public class CustomerService : ICustomerService
    {
        IUnitOfWork unitOfWork;
        IClientReporsitory clientReporsitory;

        public CustomerService(IUnitOfWork unitOfWork, IClientReporsitory clientReporsitory)
        {
            this.unitOfWork = unitOfWork;
            this.clientReporsitory = clientReporsitory;
        }

        public List<Customer> GetAllCustomers()
        {
            return clientReporsitory.GetAll().ToList();

        }

        public List<Customer> GetCustomerWithVehicles(long id)
        {
           return clientReporsitory.GetAll().ToList();
        }
    }
}
