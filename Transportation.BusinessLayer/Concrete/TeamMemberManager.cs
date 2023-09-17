using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transportation.BusinessLayer.Contracts;
using Transportation.DataAccessLayer.Contracts;
using Transportation.EntityLayer.Entities;

namespace Transportation.BusinessLayer.Concrete
{
    public class TeamMemberManager:ITeamMemberService
    {
        private readonly IRepositoryManager _manager;

        public TeamMemberManager(IRepositoryManager manager)
        {
            _manager = manager;
        }

        public List<TeamMember> GetAllTeamMembers()
        {
            return _manager.TeamMemberRepository.GetAllTeamMembers();
        }

        public List<TeamMember> GetTeamMembersById(int teamId)
        {
            return _manager.TeamMemberRepository.GetTeamMembersById(teamId);
        }
    }
}
