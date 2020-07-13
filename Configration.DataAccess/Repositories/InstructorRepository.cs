using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configration.Domain;
using Configration.Domain.Entities;
namespace Configration.DataAccess.Repositories
{
    public class InstructorRepository:GenericRepository<Instructor>,IinstructorRepository
    {
        private readonly ApplicationDbContext context;

        public InstructorRepository(ApplicationDbContext context):base(context)
        {
            this.context = context;
        }

        public IEnumerable<model> GetAllInstructor()
        {
            return context.Instructors.Select(x =>new model{ID= x.InstructorID,Name= x.Name }).ToList();
        }
    }
}
