using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Model.Entities;

namespace TrackingSystem.Service.Contracts
{
    public interface IStatusService
    {
        List<Status> GetStatuses();
    }
}
