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
    public class TeamMemberConfig : IEntityTypeConfiguration<TeamMember>
    {
        public void Configure(EntityTypeBuilder<TeamMember> builder)
        {
            builder.HasData(
                new TeamMember() { TeamMemberId=1,TransportTeamId=1,Name="Aslı Aslan",Position="Expert",Image="~/logistica-1.0.0/img/team-1.jpg", },
                new TeamMember() { TeamMemberId=2,TransportTeamId=1,Name="Sezai Sezgin",Position="Expert",Image="~/logistica-1.0.0/img/team-2.jpg"},
                new TeamMember() { TeamMemberId = 3, TransportTeamId = 1, Name = "Ayhan Keser", Position = "Expert", Image = "~/logistica-1.0.0/img/team-3.jpg" },
                new TeamMember() { TeamMemberId = 4, TransportTeamId = 1, Name = "Ferdi Geldi", Position = "Expert", Image = "~/logistica-1.0.0/img/team-4.jpg" }
                );
        }
    }
}
