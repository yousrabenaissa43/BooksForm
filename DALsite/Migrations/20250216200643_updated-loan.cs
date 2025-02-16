using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DALsite.Migrations
{
    /// <inheritdoc />
    public partial class updatedloan : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Book_Id",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_Id",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Loans");

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BookId",
                table: "Loans",
                column: "BookId");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Book_BookId",
                table: "Loans",
                column: "BookId",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Book_BookId",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_BookId",
                table: "Loans");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Loans",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_Id",
                table: "Loans",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Book_Id",
                table: "Loans",
                column: "Id",
                principalTable: "Book",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
