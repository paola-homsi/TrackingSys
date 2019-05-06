using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.Model.Entities
{
    public class Status
    {
        [Key]
        public int ID { get; set; }
        public string Title { get; set; }
        public virtual ICollection<Vehicle_Status_Log> Status_Logs { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
