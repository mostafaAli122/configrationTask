using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Configration.Domain;
using Configration.Domain.Entities;

namespace Configration.DataAccess.Repositories
{
    public class StudentRepository:GenericRepository<Student>,IStudentRepository
    {
        private readonly ApplicationDbContext context;

        public StudentRepository(ApplicationDbContext context):base(context)
        {
            this.context = context;
        }

        public IEnumerable<model> GetAllStudents()
        {
            return context.Students.Select(x => new model { ID = x.StudentID, Name = x.Name });
        }
    }
}
