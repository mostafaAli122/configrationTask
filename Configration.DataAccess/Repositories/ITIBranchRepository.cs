using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configration.Domain;
using Configration.Domain.Entities;

namespace Configration.DataAccess.Repositories
{
    public class ITIBranchRepository:GenericRepository<ITIBranch>,IITIBranchRepository
    {
        private readonly ApplicationDbContext context;

        public ITIBranchRepository(ApplicationDbContext context) : base(context)
        {
            this.context = context;
        }

        public IEnumerable<model> GetAllBranches()
        {
            return context.ITIBranchs.Select(x => new model { ID = x.ITIBranchID, Name = x.Name });
        }
    }
}
