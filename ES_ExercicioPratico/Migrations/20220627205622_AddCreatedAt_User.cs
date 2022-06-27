using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ES_ExercicioPratico.Migrations
{
    public partial class AddCreatedAt_User : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Keys",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "User",
                table: "Keys",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Keys");

            migrationBuilder.DropColumn(
                name: "User",
                table: "Keys");
        }
    }
}
