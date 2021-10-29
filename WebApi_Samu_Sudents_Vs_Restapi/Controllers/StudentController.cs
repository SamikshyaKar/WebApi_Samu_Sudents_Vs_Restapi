using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Samu_Sudents_Vs_Restapi.Models;
using WebApi_Samu_Sudents_Vs_Restapi.InterfaceData;

namespace WebApi_Samu_Sudents_Vs_Restapi.Controllers
{

   

    [Route("api/[controller]")]
        [ApiController]
    public class StudentController : Controller
    {

        private readonly SQLStudentsRepo _Studentrepository;
        public StudentController(SQLStudentsRepo studentDetailRepo)
        {
            _Studentrepository = studentDetailRepo;
        }
       //private readonly MockStudentDetailsRepo _mockStudentDetailsRepo = new MockStudentDetailsRepo();
      

        [HttpGet]
        public ActionResult <IEnumerable<StudentDetails>> GetAllTHEStudentDetails()
        {
            var students = _Studentrepository.GetAllStudentDetails();
            return Ok(students);
        }

        [HttpGet("{id}")]
        public ActionResult <StudentDetails> GetSAllThetudentDetailByID(int SID)
        {
            var student = _Studentrepository.GetStudentDetailByID(SID);
            return Ok(student);
        }
    }
}
