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
    public class TransportTeamConfig : IEntityTypeConfiguration<TransportTeam>
    {
        public void Configure(EntityTypeBuilder<TransportTeam> builder)
        {
            builder.HasData(
                new TransportTeam() {TransportTeamId=1,TeamName="X Taşıma Ekibi",Description="Deneyimli taşımacılar" }
                );
        }
    }
}
