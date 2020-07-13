using Configration.Domain;
using Configration.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configration.DataAccess.Repositories
{
   public class ITIBranchConfigrationKeyRepository: GenericRepository<C_ITIBranchConfigurationKeys>,IITIBranchConfigrationKeyRepository
    {
        private readonly ApplicationDbContext context;

        public ITIBranchConfigrationKeyRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<model> GetAllBranchesConfigKeys()
        {
            return context.C_ITIBranchConfigurationKeys.Select(x => new model { ID = x.C_ITIBranchConfigurationsKeyID, Name = x.NameE }).ToList();
        }
    }
}
