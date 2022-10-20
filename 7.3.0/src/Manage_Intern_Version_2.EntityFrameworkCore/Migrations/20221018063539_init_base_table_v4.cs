using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Manage_Intern_Version_2.Migrations
{
    public partial class init_base_table_v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Intern_InternId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Mentor_MentorId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_InternId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_MentorId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "InternId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "MentorId",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Mentor",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Intern",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Mentor_UserId",
                table: "Mentor",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Intern_UserId",
                table: "Intern",
                column: "UserId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Intern_User_UserId",
                table: "Intern");

            migrationBuilder.DropForeignKey(
                name: "FK_Mentor_User_UserId",
                table: "Mentor");

            migrationBuilder.DropIndex(
                name: "IX_Mentor_UserId",
                table: "Mentor");

            migrationBuilder.DropIndex(
                name: "IX_Intern_UserId",
                table: "Intern");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Mentor");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Intern");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "User",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<int>(
                name: "InternId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MentorId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_InternId",
                table: "User",
                column: "InternId");

            migrationBuilder.CreateIndex(
                name: "IX_User_MentorId",
                table: "User",
                column: "MentorId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Intern_InternId",
                table: "User",
                column: "InternId",
                principalTable: "Intern",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Mentor_MentorId",
                table: "User",
                column: "MentorId",
                principalTable: "Mentor",
                principalColumn: "Id");
        }
    }
}
