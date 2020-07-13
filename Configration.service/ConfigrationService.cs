using Configration.Domain;
using Configration.DataAccess;
using Configration.DataAccess.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Configration.Domain.Entities;

namespace Configration.service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class ConfigrationService : IConfigrationService
    {
         UnitOfWork unitOfWork;
        ApplicationDbContext context;
       
        public ConfigrationService()
        {
            this.context = new ApplicationDbContext();
            this.unitOfWork = new UnitOfWork(context);
        }

        public List<model> GetAllBranchesConfigKeys()
        {
            return unitOfWork.ITIBranchConfigrationKeys.GetAllBranchesConfigKeys().ToList();
        }

        public List<model> GetAllInstructors()
        {
            return unitOfWork.Instructors.GetAllInstructor().ToList();
        }

        public List<model> GetAllInstructorsConfigKeys()
        {
            return unitOfWork.InstructorConfigrationKeys.GetAllInstructorConfigKeys().ToList();
        }

        public List<model> GetAllITIBranches()
        {
            return unitOfWork.ITIBranchs.GetAllBranches().ToList();

        }

        public List<model> GetAllStudents()
        {
            return unitOfWork.Students.GetAllStudents().ToList();

        }

        public List<model> GetAllStudentsConfigKeys()
        {
            return unitOfWork.StudentConfigrationKeys.GetAllStudentsConfigKeys().ToList();
        }

        public string GetInstructorConfigValue(int InstructorID, int InstructorConfigKeyId)
        {
            return unitOfWork.InstructorConfigration.GetInstructorConfigurationsValue(InstructorID, InstructorConfigKeyId);
        }

        public string GetITIBranchConfigValue(int BranchID, int BranchConfigKeyId)
        {
            return unitOfWork.ITIBranchConfigrations.GetITIBranchConfigurationsValue(BranchID, BranchConfigKeyId);
        }

        public string GetStudentConfigValue(int StudentID, int StudentConfigKeyId)
        {
            return unitOfWork.StudentConfigrations.GetStudentConfigurationsValue(StudentID, StudentConfigKeyId);
        }
    }
}
