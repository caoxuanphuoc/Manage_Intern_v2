using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Manage_Intern_Version_2.Migrations
{
    public partial class init_base_table_v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_User_IdMentor",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IdIntern",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IdMentor",
                table: "User");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "IdIntern",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMentor",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_User_IdIntern",
                table: "User",
                column: "IdIntern");

            migrationBuilder.CreateIndex(
                name: "IX_User_IdMentor",
                table: "User",
                column: "IdMentor");

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
    }
}
