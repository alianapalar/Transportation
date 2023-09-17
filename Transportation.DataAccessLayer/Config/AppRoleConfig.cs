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
    public class AppRoleConfig : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            builder.HasData(
                new AppRole() { Id = 1, Name = "Admin", NormalizedName = "ADMIN" },
                new AppRole() { Id = 2, Name = "User", NormalizedName = "USER" });
        }
    }
}
