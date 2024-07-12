using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace south_country_garden.Migrations
{
    public partial class audit3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "booking_id",
                table: "audit_trail",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "accounts",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_audit_trail_booking_id",
                table: "audit_trail",
                column: "booking_id");

            migrationBuilder.AddForeignKey(
                name: "FK_audit_trail_booking_records_booking_id",
                table: "audit_trail",
                column: "booking_id",
                principalTable: "booking_records",
                principalColumn: "booking_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_audit_trail_booking_records_booking_id",
                table: "audit_trail");

            migrationBuilder.DropIndex(
                name: "IX_audit_trail_booking_id",
                table: "audit_trail");

            migrationBuilder.DropColumn(
                name: "booking_id",
                table: "audit_trail");

            migrationBuilder.AlterColumn<string>(
                name: "username",
                table: "accounts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);
        }
    }
}
