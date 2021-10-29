using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Samu_Sudents_Vs_Restapi.Models
{
    public class StudentDetails
    {
        [Key]
        public int studID { get; set; }
        public string studName { get; set; }

        public string  StudAddress { get; set; }
        public int  studAge { get; set; }


    }
}
