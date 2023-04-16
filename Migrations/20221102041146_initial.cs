using Microsoft.EntityFrameworkCore.Migrations;

namespace Candidate_Info.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Basic_Info",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Pradesh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PratinidhiSabha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PradeshSabha = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RajnitikDal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ummedwar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basic_Info", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Basic_Info");
        }
    }
}
