using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicalMusic.DATA.Migrations
{
    /// <inheritdoc />
    public partial class AddCreatorId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Creators_CreatorId",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "CreatorId",
                table: "Songs",
                newName: "creatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_CreatorId",
                table: "Songs",
                newName: "IX_Songs_creatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Creators_creatorId",
                table: "Songs",
                column: "creatorId",
                principalTable: "Creators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Creators_creatorId",
                table: "Songs");

            migrationBuilder.RenameColumn(
                name: "creatorId",
                table: "Songs",
                newName: "CreatorId");

            migrationBuilder.RenameIndex(
                name: "IX_Songs_creatorId",
                table: "Songs",
                newName: "IX_Songs_CreatorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Creators_CreatorId",
                table: "Songs",
                column: "CreatorId",
                principalTable: "Creators",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
