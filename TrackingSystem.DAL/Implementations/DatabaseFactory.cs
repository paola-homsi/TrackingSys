using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackingSystem.DAL.Contracts;
using TrackingSystem.Model;

namespace TrackingSystem.DAL.Implementations
{
   public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private TrackingVehiclesContext dataContext;

        public TrackingVehiclesContext Get()
        {
            return dataContext ?? (dataContext = new TrackingVehiclesContext());
        }
        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }
}
