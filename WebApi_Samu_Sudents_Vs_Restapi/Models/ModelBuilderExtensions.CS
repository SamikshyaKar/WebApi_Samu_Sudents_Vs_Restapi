using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi_Samu_Sudents_Vs_Restapi.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentDetails>().HasData(
        new StudentDetails
        {
            studID = 1,
            studAge = 12,
            studName = "Samu",
            StudAddress = "CTC"
        },
         new StudentDetails
         {
             studID = 2,
             studAge = 15,
             studName = "Samu1",
             StudAddress = "CTC1"
         },
          new StudentDetails
          {
              studID = 3,
              studAge = 16,
              studName = "Samu2",
              StudAddress = "CTC2"
          },
           new StudentDetails
           {
               studID = 4,
               studAge = 19,
               studName = "Samu3",
               StudAddress = "CTC3"
           }
           
           );   


        }

    }
}
