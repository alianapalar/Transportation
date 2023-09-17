using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.EntityLayer.Entities;

namespace Transportation.DataAccessLayer.Contracts
{
    public interface ITeamMemberRepository:IRepositoryBase<TeamMember>
    {
        List<TeamMember> GetAllTeamMembers();
        List<TeamMember> GetTeamMembersById(int teamId);
    }
}
