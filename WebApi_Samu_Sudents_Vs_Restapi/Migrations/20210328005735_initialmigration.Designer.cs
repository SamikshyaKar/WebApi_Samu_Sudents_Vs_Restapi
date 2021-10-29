﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApi_Samu_Sudents_Vs_Restapi.InterfaceData;

namespace WebApi_Samu_Sudents_Vs_Restapi.Migrations
{
    [DbContext(typeof(StudentDetailsContext))]
    [Migration("20210328005735_initialmigration")]
    partial class initialmigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApi_Samu_Sudents_Vs_Restapi.Models.StudentDetails", b =>
                {
                    b.Property<int>("studID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("StudAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("studAge")
                        .HasColumnType("int");

                    b.Property<string>("studName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("studID");

                    b.ToTable("dbStudents");
                });
#pragma warning restore 612, 618
        }
    }
}
