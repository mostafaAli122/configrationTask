using Configration.DataAccess.Repositories;
using Configration.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configration.DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            Instructors = new InstructorRepository(_context);
            InstructorConfigrationKeys = new InstructorConfigrationKeyRepository(_context);
            Students = new StudentRepository(_context);
            StudentConfigrationKeys = new StudentConfigrationKeyRepository(_context);
            ITIBranchs = new ITIBranchRepository(_context);
            ITIBranchConfigrationKeys = new ITIBranchConfigrationKeyRepository(_context);
            ITIBranchConfigrations = new ITIBranchConfigrationsRepository(_context);
            StudentConfigrations = new StudentConfigrationsRepository(_context);
            InstructorConfigration = new InstructorConfigrationRepository(_context);
        }


       public IinstructorRepository Instructors { get; private set; }
       public IinstructorConfigrationKeyRepository InstructorConfigrationKeys { get; private set; }
       public IStudentRepository Students { get; private set; }
       public IStudentConfigrationKeyRepository StudentConfigrationKeys { get; private set; }
       public IITIBranchRepository ITIBranchs { get; private set; }
        public IITIBranchConfigrationKeyRepository ITIBranchConfigrationKeys { get; private set; }

        public IITIBranchConfigrationsRepository ITIBranchConfigrations { get; private set; }
        public IStudentConfigrationsRepository StudentConfigrations { get; private set; }

        public IInstructorConfigrationRepository InstructorConfigration { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
