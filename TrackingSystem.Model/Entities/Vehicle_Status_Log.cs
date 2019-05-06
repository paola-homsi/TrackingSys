using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.Model.Entities
{
    public class Vehicle_Status_Log
    {
        [Key]
        public int ID { get; set; }
        public int VehicleID { get; set; }
        public int StatusID { get; set; }
        
        public DateTime dateTime { get; set; }

        [ForeignKey("StatusID")]
        public virtual Status Status { get; set; }
        [ForeignKey("VehicleID")]
        public virtual Vehicle Vehicle { get; set; }
    }
}
