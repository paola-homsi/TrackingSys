using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackingSystem.Model.Entities
{
    public class Vehicle
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string PlateNumber { get; set; }
        [Required]
        public string RegNum { get; set; }
        public int Status_Id { get; set; }
        public string DeviceID { get; set; }
        public int CustomerID { get; set; }
        [ForeignKey("CustomerID")]
        public virtual Customer Owner { get; set; }
        [ForeignKey("Status_Id")]
        public virtual Status Status { get; set; }
        public virtual ICollection<Vehicle_Status_Log> Status_Logs { get; set; }
    }
}
