using Microsoft.EntityFrameworkCore.Migrations;

namespace RealMission7.Migrations
{
    public partial class payUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "OrderShipped",
                table: "Payment",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OrderShipped",
                table: "Payment");
        }
    }
}
