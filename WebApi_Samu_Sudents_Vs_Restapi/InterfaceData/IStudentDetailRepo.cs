using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Samu_Sudents_Vs_Restapi.Models;

namespace WebApi_Samu_Sudents_Vs_Restapi.InterfaceData
{
    public interface IStudentDetailRepo
    {
        IEnumerable<StudentDetails> GetAllStudentDetails();
        StudentDetails GetStudentDetailByID(int SID);

    }
}
