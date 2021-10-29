using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApi_Samu_Sudents_Vs_Restapi.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "dbStudents",
                columns: table => new
                {
                    studID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    studAge = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dbStudents", x => x.studID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "dbStudents");
        }
    }
}
