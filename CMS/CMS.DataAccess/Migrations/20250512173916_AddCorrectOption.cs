using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CMS.Migrations
{
    /// <inheritdoc />
    public partial class AddCorrectOption : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CorrectOptionId",
                table: "ExamQuestions");

            migrationBuilder.AlterColumn<int>(
                name: "Marks",
                table: "ExamQuestions",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(5,2)");

            migrationBuilder.AddColumn<bool>(
                name: "IsCorrect",
                table: "ExamOption",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCorrect",
                table: "ExamOption");

            migrationBuilder.AlterColumn<decimal>(
                name: "Marks",
                table: "ExamQuestions",
                type: "decimal(5,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CorrectOptionId",
                table: "ExamQuestions",
                type: "int",
                nullable: true);
        }
    }
}
