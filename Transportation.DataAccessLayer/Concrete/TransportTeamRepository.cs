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
    public class TransportTeamRepository : RepositoryBase<TransportTeam>, ITransportTeamRepository
    {
        public TransportTeamRepository(TransportationContext context) : base(context)
        {
        }

        public List<TransportTeam> GetAllTransportTeams()
        {
            return _context.TransportTeams.Include(t=>t.TeamMembers).ToList();
        }

        
    }
}
