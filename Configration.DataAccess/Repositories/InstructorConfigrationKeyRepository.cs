using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configration.Domain;
using Configration.Domain.Entities;

namespace Configration.DataAccess.Repositories
{
    public class InstructorConfigrationKeyRepository: GenericRepository<C_InstructorConfigurationKeys>,IinstructorConfigrationKeyRepository
    {
        private readonly ApplicationDbContext context;

        public InstructorConfigrationKeyRepository(ApplicationDbContext context ):base(context)
        {
            this.context = context;
        }

        public IEnumerable<model> GetAllInstructorConfigKeys()
        {
            return context.C_InstructorConfigurationKeys.Select(x => new model { ID = x.C_InstructorConfigurationsKeyID, Name = x.NameE }).ToList();
        }
    }
}
