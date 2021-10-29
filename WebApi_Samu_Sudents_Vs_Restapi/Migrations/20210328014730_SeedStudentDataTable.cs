using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_Samu_Sudents_Vs_Restapi.Migrations
{
    public partial class SeedStudentDataTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "dbStudents",
                columns: new[] { "studID", "StudAddress", "studAge", "studName" },
                values: new object[,]
                {
                    { 1, "CTC", 12, "Samu" },
                    { 2, "CTC1", 15, "Samu1" },
                    { 3, "CTC2", 16, "Samu2" },
                    { 4, "CTC3", 19, "Samu3" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "dbStudents",
                keyColumn: "studID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "dbStudents",
                keyColumn: "studID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "dbStudents",
                keyColumn: "studID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "dbStudents",
                keyColumn: "studID",
                keyValue: 4);
        }
    }
}
