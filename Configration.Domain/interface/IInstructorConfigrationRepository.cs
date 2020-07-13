using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configration.Domain
{
    public interface IInstructorConfigrationRepository:IGenericRepository<InstructorConfiguration>
    {
        string GetInstructorConfigurationsValue(int InstructorID, int InstructorConfigurationsKeyID);
    }
}
