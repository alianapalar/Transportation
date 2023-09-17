using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.DataAccessLayer.Context;
using Transportation.DataAccessLayer.Contracts;
using Transportation.EntityLayer.Entities;

namespace Transportation.DataAccessLayer.Concrete
{
    public class TeamMemberRepository : RepositoryBase<TeamMember>, ITeamMemberRepository
    {
        public TeamMemberRepository(TransportationContext context) : base(context)
        {
        }

        public List<TeamMember> GetAllTeamMembers()
        {
            return _context.TeamMembers.ToList();
        }

        public List<TeamMember> GetTeamMembersById(int teamId)
        {
            return _context.TeamMembers.Where(t=>t.TransportTeamId.Equals(teamId)).ToList();
        }
    }
}
