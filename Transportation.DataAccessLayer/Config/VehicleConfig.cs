using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.EntityLayer.Entities;

namespace Transportation.DataAccessLayer.Config
{
    public class VehicleConfig : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData(
                new Vehicle() {VehicleId=1,VehicleInfo= "Chrysler",DriverId=1, Image="~/logistica-1.0.0/img/service-3.jpg",VehicleType="Tır"},
                new Vehicle() { VehicleId = 2, VehicleInfo = "Mercedes Benz",DriverId=2,  Image = "~/logistica-1.0.0/img/service-6.jpg", VehicleType = "Kamyon" },
                new Vehicle() {VehicleId = 3, VehicleInfo = "DAF", DriverId = 3, Image = "~/logistica-1.0.0/img/service-1.jpg" , VehicleType = "Tır" },
                new Vehicle() {VehicleId = 4, VehicleInfo = "Scania", DriverId = 4, Image = "~/logistica-1.0.0/img/service-2.jpg", VehicleType = "Kamyon" },
                new Vehicle() {VehicleId = 5, VehicleInfo = "BMC", DriverId = 5, Image = "~/logistica-1.0.0/img/service-4.jpg", VehicleType = "Kamyonet" }
                );
        }
    }
}
