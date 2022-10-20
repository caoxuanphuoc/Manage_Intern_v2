using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Manage_Intern_Version_2.Migrations
{
    public partial class init_base_table_v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Intern_UserCode",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Mentor_MentorId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_MentorId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "MentorId",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "UserCode",
                table: "User",
                newName: "IdMentor");

            migrationBuilder.RenameIndex(
                name: "IX_User_UserCode",
                table: "User",
                newName: "IX_User_IdMentor");

            migrationBuilder.AddColumn<int>(
                name: "IdIntern",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_IdIntern",
                table: "User",
                column: "IdIntern");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Intern_IdIntern",
                table: "User",
                column: "IdIntern",
                principalTable: "Intern",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Mentor_IdMentor",
                table: "User",
                column: "IdMentor",
                principalTable: "Mentor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_Intern_IdIntern",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Mentor_IdMentor",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_IdIntern",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IdIntern",
                table: "User");

            migrationBuilder.RenameColumn(
                name: "IdMentor",
                table: "User",
                newName: "UserCode");

            migrationBuilder.RenameIndex(
                name: "IX_User_IdMentor",
                table: "User",
                newName: "IX_User_UserCode");

            migrationBuilder.AddColumn<int>(
                name: "MentorId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_User_MentorId",
                table: "User",
                column: "MentorId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_Intern_UserCode",
                table: "User",
                column: "UserCode",
                principalTable: "Intern",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Mentor_MentorId",
                table: "User",
                column: "MentorId",
                principalTable: "Mentor",
                principalColumn: "Id");
        }
    }
}
