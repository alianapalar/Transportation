using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.EntityLayer.Entities
{
    public class Vehicle
    {
        public int VehicleId { get; set; }
        public string VehicleType { get; set; }
        public string Image { get; set; }
        public string VehicleInfo { get; set; }
        public int? DriverId { get; set; }
        [ForeignKey("DriverId")]
        public Driver Driver { get; set; }
        
    }
}
