using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Configration.Domain;
using Configration.Domain.Entities;
namespace Configration.service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IConfigrationService
    {
        [OperationContract]
        List<model> GetAllStudents();
        [OperationContract]
        List<model> GetAllInstructors();
        [OperationContract]
        List<model> GetAllITIBranches();
        [OperationContract]
        List<model> GetAllBranchesConfigKeys();
        [OperationContract]
        List<model> GetAllStudentsConfigKeys();
        [OperationContract]
        List<model> GetAllInstructorsConfigKeys();

        [OperationContract]
        string GetITIBranchConfigValue(int BranchID, int BranchConfigKeyId);
        [OperationContract]
        string GetInstructorConfigValue(int InstructorID, int InstructorConfigKeyId);
        [OperationContract]
        string GetStudentConfigValue(int StudentID, int StudentConfigKEyId);


    }

}
