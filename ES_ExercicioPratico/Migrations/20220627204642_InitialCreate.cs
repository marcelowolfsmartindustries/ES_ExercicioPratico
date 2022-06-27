using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ES_ExercicioPratico.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Keys",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number1 = table.Column<short>(type: "smallint", nullable: false),
                    Number2 = table.Column<short>(type: "smallint", nullable: false),
                    Number3 = table.Column<short>(type: "smallint", nullable: false),
                    Number4 = table.Column<short>(type: "smallint", nullable: false),
                    Number5 = table.Column<short>(type: "smallint", nullable: false),
                    Star1 = table.Column<short>(type: "smallint", nullable: false),
                    Start2 = table.Column<short>(type: "smallint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Keys", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Keys");
        }
    }
}
