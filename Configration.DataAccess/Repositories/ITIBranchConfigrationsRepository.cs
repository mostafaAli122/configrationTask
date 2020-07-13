using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Configration.Domain;
using Configration.Domain.Entities;

namespace Configration.DataAccess.Repositories
{
    public class ITIBranchConfigrationsRepository : GenericRepository<ITIBranchConfiguration>, IITIBranchConfigrationsRepository
    {
        private readonly ApplicationDbContext context;

        public ITIBranchConfigrationsRepository(ApplicationDbContext context):base(context)
        {
            this.context = context;
        }
        public string GetITIBranchConfigurationsValue(int ITIBranchID, int ITIBranchConfigurationsKeyID)
        {

            return context.ITIBranchConfigurations.FirstOrDefault(x => x.ITIBranchID == ITIBranchID && x.C_ITIBranchConfigurationsKeyID == ITIBranchConfigurationsKeyID)?.ITIBranchConfigurationsValue ?? context.C_ITIBranchConfigurationKeys.FirstOrDefault(x => x.C_ITIBranchConfigurationsKeyID == ITIBranchConfigurationsKeyID)?.C_ITIBranchConfigurationKeyValue??"";
        }

        
       
    }
}
