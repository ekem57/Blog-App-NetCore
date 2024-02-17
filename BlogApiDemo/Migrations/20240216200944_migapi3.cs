using Microsoft.EntityFrameworkCore.Migrations;

namespace BlogApiDemo.Migrations
{
    public partial class migapi3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NotificationType",
                table: "Notifications",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "NotificationID",
                table: "Notifications",
                newName: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Notifications",
                newName: "NotificationType");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Notifications",
                newName: "NotificationID");
        }
    }
}
