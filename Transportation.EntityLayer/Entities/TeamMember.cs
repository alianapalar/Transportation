using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.EntityLayer.Entities
{
    public class TeamMember
    {
        public int TeamMemberId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Image { get; set; }
        public int TransportTeamId { get; set; }
        public TransportTeam TransportTeam { get; set; }
        
    }
}
