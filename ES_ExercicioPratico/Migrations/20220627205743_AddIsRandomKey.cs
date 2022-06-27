using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ES_ExercicioPratico.Migrations
{
    public partial class AddIsRandomKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsRandomKey",
                table: "Keys",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsRandomKey",
                table: "Keys");
        }
    }
}
