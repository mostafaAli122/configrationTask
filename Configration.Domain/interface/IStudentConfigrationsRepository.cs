using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configration.Domain
{
    public interface IStudentConfigrationsRepository: IGenericRepository<StudentConfiguration>
    {
        string GetStudentConfigurationsValue(int StudentID, int StudentConfigurationsKeyID);

    }
}
