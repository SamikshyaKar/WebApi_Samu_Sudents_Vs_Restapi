using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Samu_Sudents_Vs_Restapi.Models;

namespace WebApi_Samu_Sudents_Vs_Restapi.InterfaceData
{
    public class StudentDetailsContext:DbContext
    {
        
        public StudentDetailsContext(DbContextOptions<StudentDetailsContext> opt): base(opt)
        {

        }

        public DbSet<StudentDetails> dbStudents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

        }


    }
}
