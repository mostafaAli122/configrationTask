using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configration.Domain;
using Configration.Domain.Entities;
namespace Configration.DataAccess.Repositories
{
    public class StudentConfigrationsRepository : GenericRepository<StudentConfiguration>, IStudentConfigrationsRepository
    {
        private readonly ApplicationDbContext context;

        public StudentConfigrationsRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }
        public string GetStudentConfigurationsValue(int StudentID, int StudentConfigurationsKeyID)
        {
            return context.StudentConfigurations.FirstOrDefault(x => x.StudentID == StudentID && x.C_StudentConfigurationsKeyID == StudentConfigurationsKeyID)?.StudentConfigurationsValue??context.C_StudentConfigurationKeys.FirstOrDefault(c=>c.C_StudentConfigurationsKeyID== StudentConfigurationsKeyID)?.C_StudentConfigurationKeyValue??"";
        }
    }
}
