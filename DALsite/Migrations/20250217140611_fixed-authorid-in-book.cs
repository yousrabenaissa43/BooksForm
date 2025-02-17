using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DALsite.Migrations
{
    /// <inheritdoc />
    public partial class fixedauthoridinbook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AutourId",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "AutourId",
                table: "Book",
                newName: "AuthorId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_AutourId",
                table: "Book",
                newName: "IX_Book_AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AuthorId",
                table: "Book",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "AuthorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Book_Authors_AuthorId",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Book",
                newName: "AutourId");

            migrationBuilder.RenameIndex(
                name: "IX_Book_AuthorId",
                table: "Book",
                newName: "IX_Book_AutourId");

            migrationBuilder.AddForeignKey(
                name: "FK_Book_Authors_AutourId",
                table: "Book",
                column: "AutourId",
                principalTable: "Authors",
                principalColumn: "AuthorId");
        }
    }
}
