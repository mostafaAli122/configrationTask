using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configration.Domain
{
    public interface IUnitOfWork : IDisposable
    {
        IinstructorRepository Instructors { get; }
        IinstructorConfigrationKeyRepository InstructorConfigrationKeys { get; }
        IStudentRepository Students { get; }
        IStudentConfigrationKeyRepository StudentConfigrationKeys { get; }
        IITIBranchRepository ITIBranchs { get; }
        IITIBranchConfigrationKeyRepository ITIBranchConfigrationKeys { get; }
        IITIBranchConfigrationsRepository ITIBranchConfigrations { get; }
        IStudentConfigrationsRepository StudentConfigrations { get; }
        IInstructorConfigrationRepository InstructorConfigration { get; }
        int Complete();
    }
}
