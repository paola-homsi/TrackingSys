using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using TrackingSystem.Model.Entities;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace TrackingSystem.Model
{
    public class TrackingVehiclesContext : DbContext
    {
        public TrackingVehiclesContext() : base("name=TrackingSystemDB") {
            Configuration.LazyLoadingEnabled = true;
        }

        public virtual void Commit()
        {
            try
            {
                base.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Class: {0}, Property: {1}, Error: {2}", validationErrors.Entry.Entity.GetType().FullName,
                                      validationError.PropertyName, validationError.ErrorMessage);
                    }
                }
            }
        }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Status> Statuses { get; set; }
        public virtual DbSet<Vehicle_Status_Log> Vehicle_Statuses { get; set; }
    }
}
