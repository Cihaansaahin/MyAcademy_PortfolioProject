using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Portfolio.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSkillRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AboutId",
                table: "Skills",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Skills_AboutId",
                table: "Skills",
                column: "AboutId");

            migrationBuilder.AddForeignKey(
                name: "FK_Skills_Abouts_AboutId",
                table: "Skills",
                column: "AboutId",
                principalTable: "Abouts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Skills_Abouts_AboutId",
                table: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Skills_AboutId",
                table: "Skills");

            migrationBuilder.DropColumn(
                name: "AboutId",
                table: "Skills");
        }
    }
}
