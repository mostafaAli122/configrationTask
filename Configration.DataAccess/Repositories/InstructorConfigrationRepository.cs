using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configration.Domain;
using Configration.Domain.Entities;


namespace Configration.DataAccess.Repositories
{
   public class InstructorConfigrationRepository : GenericRepository<InstructorConfiguration>, IInstructorConfigrationRepository
    {
        private readonly ApplicationDbContext context;

        public InstructorConfigrationRepository(ApplicationDbContext context):base(context)
        {
            this.context = context;
        }
        public string GetInstructorConfigurationsValue(int InstructorID, int InstructorConfigurationsKeyID)
        {
            return context.InstructorConfigurations.FirstOrDefault(x => x.InstructorID == InstructorID && x.C_InstructorConfigurationsKeyID == InstructorConfigurationsKeyID)?.InstructorConfigurationsValue??context.C_InstructorConfigurationKeys.FirstOrDefault(c=>c.C_InstructorConfigurationsKeyID== InstructorConfigurationsKeyID)?.C_InstructorConfigurationKeyValue??"";
        }
    }
}
