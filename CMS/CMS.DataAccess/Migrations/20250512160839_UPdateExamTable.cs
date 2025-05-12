using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS.Migrations
{
    /// <inheritdoc />
    public partial class UPdateExamTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestions_Exams_ExamsId",
                table: "ExamQuestions");

            migrationBuilder.AlterColumn<int>(
                name: "ExamsId",
                table: "ExamQuestions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ExamId",
                table: "ExamQuestions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestions_Exams_ExamsId",
                table: "ExamQuestions",
                column: "ExamsId",
                principalTable: "Exams",
                principalColumn: "ExamsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExamQuestions_Exams_ExamsId",
                table: "ExamQuestions");

            migrationBuilder.AlterColumn<int>(
                name: "ExamsId",
                table: "ExamQuestions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ExamId",
                table: "ExamQuestions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ExamQuestions_Exams_ExamsId",
                table: "ExamQuestions",
                column: "ExamsId",
                principalTable: "Exams",
                principalColumn: "ExamsId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
