using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.DAL.Contracts;
using TrackingSystem.Model.Entities;
using TrackingSystem.Repository;
using TrackingSystem.Service.Contracts;

namespace TrackingSystem.Service.Implementations
{
    public class StatusService : IStatusService
    {
        IUnitOfWork unitOfWork;
        IStatusReporsitory statusService;

        public StatusService(IUnitOfWork unitOfWork,
            IStatusReporsitory StatusService)
        {
            this.unitOfWork = unitOfWork;
            this.statusService = StatusService;
        }
        public List<Status> GetStatuses()
        {
            return statusService.GetAll().ToList();
        }
    }
}
