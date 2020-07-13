using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configration.Domain;
using Configration.Domain.Entities;

namespace Configration.DataAccess.Repositories
{
    public class StudentConfigrationKeyRepository:GenericRepository<C_StudentConfigurationKeys>,IStudentConfigrationKeyRepository
    {
        private readonly ApplicationDbContext context;

        public StudentConfigrationKeyRepository(ApplicationDbContext context):base(context)
        {
            this.context = context;
        }

        public IEnumerable<model> GetAllStudentsConfigKeys()
        {
            return context.C_StudentConfigurationKeys.Select(x => new model { ID = x.C_StudentConfigurationsKeyID, Name = x.NameE }).ToList();
        }
    }
}
