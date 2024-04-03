using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameLib.Core.Migrations
{
    /// <inheritdoc />
    public partial class gametime_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameTime_Games_GameId",
                table: "GameTime");

            migrationBuilder.DropForeignKey(
                name: "FK_GameTime_Users_UserId",
                table: "GameTime");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameTime",
                table: "GameTime");

            migrationBuilder.RenameTable(
                name: "GameTime",
                newName: "GameTimes");

            migrationBuilder.RenameIndex(
                name: "IX_GameTime_UserId",
                table: "GameTimes",
                newName: "IX_GameTimes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_GameTime_GameId",
                table: "GameTimes",
                newName: "IX_GameTimes_GameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameTimes",
                table: "GameTimes",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GameTimes_Games_GameId",
                table: "GameTimes",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameTimes_Users_UserId",
                table: "GameTimes",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GameTimes_Games_GameId",
                table: "GameTimes");

            migrationBuilder.DropForeignKey(
                name: "FK_GameTimes_Users_UserId",
                table: "GameTimes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GameTimes",
                table: "GameTimes");

            migrationBuilder.RenameTable(
                name: "GameTimes",
                newName: "GameTime");

            migrationBuilder.RenameIndex(
                name: "IX_GameTimes_UserId",
                table: "GameTime",
                newName: "IX_GameTime_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_GameTimes_GameId",
                table: "GameTime",
                newName: "IX_GameTime_GameId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GameTime",
                table: "GameTime",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_GameTime_Games_GameId",
                table: "GameTime",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameTime_Users_UserId",
                table: "GameTime",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
