using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.Model;

namespace TrackingSystem.DAL.Contracts
{
    public interface IDatabaseFactory : IDisposable
    {
        TrackingVehiclesContext Get();
    }
}
