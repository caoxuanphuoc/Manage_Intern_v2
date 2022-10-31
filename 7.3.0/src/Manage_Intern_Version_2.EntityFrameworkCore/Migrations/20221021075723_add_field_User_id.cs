using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Manage_Intern_Version_2.Migrations
{
    public partial class add_field_User_id : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intern_User_UserId",
                table: "Intern");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentor_User_UserId",
                table: "Mentor");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Mentor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Intern",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Intern_User_UserId",
                table: "Intern",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Mentor_User_UserId",
                table: "Mentor",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intern_User_UserId",
                table: "Intern");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentor_User_UserId",
                table: "Mentor");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Mentor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Intern",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Intern_User_UserId",
                table: "Intern",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mentor_User_UserId",
                table: "Mentor",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id");
        }
    }
}
