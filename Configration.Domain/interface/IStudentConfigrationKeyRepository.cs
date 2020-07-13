using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configration.Domain.Entities;
namespace Configration.Domain
{
    public interface IStudentConfigrationKeyRepository:IGenericRepository<C_StudentConfigurationKeys>
    {
        IEnumerable<model> GetAllStudentsConfigKeys();

    }
}
