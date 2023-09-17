using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.EntityLayer.Entities;

namespace Transportation.BusinessLayer.Contracts
{
    public interface ITeamMemberService
    {
        List<TeamMember> GetAllTeamMembers();
        List<TeamMember> GetTeamMembersById(int teamId);
    }
}
