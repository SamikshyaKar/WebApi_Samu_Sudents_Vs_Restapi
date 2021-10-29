using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Samu_Sudents_Vs_Restapi.Models;

namespace WebApi_Samu_Sudents_Vs_Restapi.InterfaceData
{
    public class MockStudentDetailsRepo : IStudentDetailRepo
    {
        public IEnumerable<StudentDetails> GetAllStudentDetails()
        {
            var Students = new List<StudentDetails>
            {
                new StudentDetails{studID=1,studName = "Samu", studAge = 12, StudAddress = "CTC" },
                new StudentDetails{studID=2,studName = "ramu", studAge = 12, StudAddress = "BBSR" },
                new StudentDetails{studID=3,studName = "kamu", studAge = 12, StudAddress = "RKL" },
                new StudentDetails{studID=4,studName = "chmu", studAge = 12, StudAddress = "SMP" },
                new StudentDetails{studID=5,studName = "remu", studAge = 12, StudAddress = "KPL" }

            };

            return Students;
        }

        public StudentDetails GetStudentDetailByID(int SID)
        {
            return new StudentDetails { studID = 1, studName = "Samu", studAge = 12, StudAddress = "CTC" };
        }
    }
}
