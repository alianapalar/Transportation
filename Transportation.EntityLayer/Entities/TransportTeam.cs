using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transportation.EntityLayer.Entities
{
    public class TransportTeam
    {
        public int TransportTeamId { get; set; }
        public string TeamName { get; set; }
        public string Description { get; set; }
        public ICollection<TeamMember> TeamMembers { get; set; }
    }
}
