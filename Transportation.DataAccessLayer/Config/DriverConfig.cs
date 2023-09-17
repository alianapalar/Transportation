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
    public class DriverConfig : IEntityTypeConfiguration<Driver>
    {
        public void Configure(EntityTypeBuilder<Driver> builder)
        {
            builder.HasData(
                new Driver() {DriverId=1,DriverName= "Şükrü Şükran",Description="46 yaşında",Image="~/logistica-1.0.0/img/team-1.jpg" },
                new Driver() { DriverId = 2, DriverName = "Sezai Sezdi", Description = "36 yaşında", Image = "~/logistica-1.0.0/img/team-2.jpg" },
                new Driver() { DriverId = 3, DriverName = "Devir Daim", Description = "32 yaşında", Image = "~/logistica-1.0.0/img/team-3.jpg" },
                new Driver() { DriverId = 4, DriverName = "Engin Ermiş", Description = "49 yaşında", Image = "~/logistica-1.0.0/img/team-4.jpg" },
                new Driver() { DriverId = 5, DriverName = "Fedai Feda", Description = "60 yaşında", Image = "~/logistica-1.0.0/img/team-1.jpg" }
                );
        }
    }
}
