using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Samu_Sudents_Vs_Restapi.Models;


namespace WebApi_Samu_Sudents_Vs_Restapi.InterfaceData
{
    public class SQLStudentsRepo : IStudentDetailRepo
    {
        private readonly StudentDetailsContext _studentDetailsContext;

        public SQLStudentsRepo(StudentDetailsContext studentDetailsContext)
        {
            _studentDetailsContext = studentDetailsContext;
        }
        public IEnumerable<StudentDetails> GetAllStudentDetails()
        {
           return  _studentDetailsContext.dbStudents.ToList();
        }

        public StudentDetails GetStudentDetailByID(int SID)
        {
            return _studentDetailsContext.dbStudents.FirstOrDefault(stud => stud.studID == SID);
        }
    }
}
