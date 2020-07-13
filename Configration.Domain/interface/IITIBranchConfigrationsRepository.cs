using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configration.Domain
{
    public interface IITIBranchConfigrationsRepository:IGenericRepository<ITIBranchConfiguration>
    {
        string GetITIBranchConfigurationsValue(int ITIBranchID, int ITIBranchConfigurationsKeyID);

    }
}
