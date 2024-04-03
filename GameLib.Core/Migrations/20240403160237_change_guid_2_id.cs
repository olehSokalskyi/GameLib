using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GameLib.Core.Migrations
{
    /// <inheritdoc />
    public partial class change_guid_2_id : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperGame_Developers_DevelopersGuid",
                table: "DeveloperGame");

            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperGame_Games_GamesGuid",
                table: "DeveloperGame");

            migrationBuilder.DropForeignKey(
                name: "FK_GameGenre_Games_GamesGuid",
                table: "GameGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_GameGenre_Genres_GenresGuid",
                table: "GameGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguage_Games_GamesGuid",
                table: "GameLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguage_Languages_LanguagesGuid",
                table: "GameLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatform_Games_GamesGuid",
                table: "GamePlatform");

            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatform_Platforms_PlatformsGuid",
                table: "GamePlatform");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Publishers_PublisherGuid",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_GameUser_Games_GamesGuid",
                table: "GameUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Games_GameGuid",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Games_GameGuid",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleGuid",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "RoleGuid",
                table: "Users",
                newName: "RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleGuid",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Roles",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GameGuid",
                table: "Ratings",
                newName: "GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_GameGuid",
                table: "Ratings",
                newName: "IX_Ratings_GameId");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Publishers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Platforms",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GameGuid",
                table: "Payments",
                newName: "GameId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_GameGuid",
                table: "Payments",
                newName: "IX_Payments_GameId");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Languages",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Genres",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GamesGuid",
                table: "GameUser",
                newName: "GamesId");

            migrationBuilder.RenameColumn(
                name: "PublisherGuid",
                table: "Games",
                newName: "PublisherId");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Games",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Games_PublisherGuid",
                table: "Games",
                newName: "IX_Games_PublisherId");

            migrationBuilder.RenameColumn(
                name: "PlatformsGuid",
                table: "GamePlatform",
                newName: "PlatformsId");

            migrationBuilder.RenameColumn(
                name: "GamesGuid",
                table: "GamePlatform",
                newName: "GamesId");

            migrationBuilder.RenameIndex(
                name: "IX_GamePlatform_PlatformsGuid",
                table: "GamePlatform",
                newName: "IX_GamePlatform_PlatformsId");

            migrationBuilder.RenameColumn(
                name: "LanguagesGuid",
                table: "GameLanguage",
                newName: "LanguagesId");

            migrationBuilder.RenameColumn(
                name: "GamesGuid",
                table: "GameLanguage",
                newName: "GamesId");

            migrationBuilder.RenameIndex(
                name: "IX_GameLanguage_LanguagesGuid",
                table: "GameLanguage",
                newName: "IX_GameLanguage_LanguagesId");

            migrationBuilder.RenameColumn(
                name: "GenresGuid",
                table: "GameGenre",
                newName: "GenresId");

            migrationBuilder.RenameColumn(
                name: "GamesGuid",
                table: "GameGenre",
                newName: "GamesId");

            migrationBuilder.RenameIndex(
                name: "IX_GameGenre_GenresGuid",
                table: "GameGenre",
                newName: "IX_GameGenre_GenresId");

            migrationBuilder.RenameColumn(
                name: "Guid",
                table: "Developers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "GamesGuid",
                table: "DeveloperGame",
                newName: "GamesId");

            migrationBuilder.RenameColumn(
                name: "DevelopersGuid",
                table: "DeveloperGame",
                newName: "DevelopersId");

            migrationBuilder.RenameIndex(
                name: "IX_DeveloperGame_GamesGuid",
                table: "DeveloperGame",
                newName: "IX_DeveloperGame_GamesId");

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperGame_Developers_DevelopersId",
                table: "DeveloperGame",
                column: "DevelopersId",
                principalTable: "Developers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperGame_Games_GamesId",
                table: "DeveloperGame",
                column: "GamesId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenre_Games_GamesId",
                table: "GameGenre",
                column: "GamesId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenre_Genres_GenresId",
                table: "GameGenre",
                column: "GenresId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguage_Games_GamesId",
                table: "GameLanguage",
                column: "GamesId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguage_Languages_LanguagesId",
                table: "GameLanguage",
                column: "LanguagesId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Games_GamesId",
                table: "GamePlatform",
                column: "GamesId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Platforms_PlatformsId",
                table: "GamePlatform",
                column: "PlatformsId",
                principalTable: "Platforms",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Publishers_PublisherId",
                table: "Games",
                column: "PublisherId",
                principalTable: "Publishers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameUser_Games_GamesId",
                table: "GameUser",
                column: "GamesId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Games_GameId",
                table: "Payments",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Games_GameId",
                table: "Ratings",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperGame_Developers_DevelopersId",
                table: "DeveloperGame");

            migrationBuilder.DropForeignKey(
                name: "FK_DeveloperGame_Games_GamesId",
                table: "DeveloperGame");

            migrationBuilder.DropForeignKey(
                name: "FK_GameGenre_Games_GamesId",
                table: "GameGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_GameGenre_Genres_GenresId",
                table: "GameGenre");

            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguage_Games_GamesId",
                table: "GameLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_GameLanguage_Languages_LanguagesId",
                table: "GameLanguage");

            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatform_Games_GamesId",
                table: "GamePlatform");

            migrationBuilder.DropForeignKey(
                name: "FK_GamePlatform_Platforms_PlatformsId",
                table: "GamePlatform");

            migrationBuilder.DropForeignKey(
                name: "FK_Games_Publishers_PublisherId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_GameUser_Games_GamesId",
                table: "GameUser");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Games_GameId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Ratings_Games_GameId",
                table: "Ratings");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Users",
                newName: "RoleGuid");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                newName: "IX_Users_RoleGuid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Roles",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Ratings",
                newName: "GameGuid");

            migrationBuilder.RenameIndex(
                name: "IX_Ratings_GameId",
                table: "Ratings",
                newName: "IX_Ratings_GameGuid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Publishers",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Platforms",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "GameId",
                table: "Payments",
                newName: "GameGuid");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_GameId",
                table: "Payments",
                newName: "IX_Payments_GameGuid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Languages",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Genres",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "GamesId",
                table: "GameUser",
                newName: "GamesGuid");

            migrationBuilder.RenameColumn(
                name: "PublisherId",
                table: "Games",
                newName: "PublisherGuid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Games",
                newName: "Guid");

            migrationBuilder.RenameIndex(
                name: "IX_Games_PublisherId",
                table: "Games",
                newName: "IX_Games_PublisherGuid");

            migrationBuilder.RenameColumn(
                name: "PlatformsId",
                table: "GamePlatform",
                newName: "PlatformsGuid");

            migrationBuilder.RenameColumn(
                name: "GamesId",
                table: "GamePlatform",
                newName: "GamesGuid");

            migrationBuilder.RenameIndex(
                name: "IX_GamePlatform_PlatformsId",
                table: "GamePlatform",
                newName: "IX_GamePlatform_PlatformsGuid");

            migrationBuilder.RenameColumn(
                name: "LanguagesId",
                table: "GameLanguage",
                newName: "LanguagesGuid");

            migrationBuilder.RenameColumn(
                name: "GamesId",
                table: "GameLanguage",
                newName: "GamesGuid");

            migrationBuilder.RenameIndex(
                name: "IX_GameLanguage_LanguagesId",
                table: "GameLanguage",
                newName: "IX_GameLanguage_LanguagesGuid");

            migrationBuilder.RenameColumn(
                name: "GenresId",
                table: "GameGenre",
                newName: "GenresGuid");

            migrationBuilder.RenameColumn(
                name: "GamesId",
                table: "GameGenre",
                newName: "GamesGuid");

            migrationBuilder.RenameIndex(
                name: "IX_GameGenre_GenresId",
                table: "GameGenre",
                newName: "IX_GameGenre_GenresGuid");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Developers",
                newName: "Guid");

            migrationBuilder.RenameColumn(
                name: "GamesId",
                table: "DeveloperGame",
                newName: "GamesGuid");

            migrationBuilder.RenameColumn(
                name: "DevelopersId",
                table: "DeveloperGame",
                newName: "DevelopersGuid");

            migrationBuilder.RenameIndex(
                name: "IX_DeveloperGame_GamesId",
                table: "DeveloperGame",
                newName: "IX_DeveloperGame_GamesGuid");

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperGame_Developers_DevelopersGuid",
                table: "DeveloperGame",
                column: "DevelopersGuid",
                principalTable: "Developers",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DeveloperGame_Games_GamesGuid",
                table: "DeveloperGame",
                column: "GamesGuid",
                principalTable: "Games",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenre_Games_GamesGuid",
                table: "GameGenre",
                column: "GamesGuid",
                principalTable: "Games",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameGenre_Genres_GenresGuid",
                table: "GameGenre",
                column: "GenresGuid",
                principalTable: "Genres",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguage_Games_GamesGuid",
                table: "GameLanguage",
                column: "GamesGuid",
                principalTable: "Games",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameLanguage_Languages_LanguagesGuid",
                table: "GameLanguage",
                column: "LanguagesGuid",
                principalTable: "Languages",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Games_GamesGuid",
                table: "GamePlatform",
                column: "GamesGuid",
                principalTable: "Games",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GamePlatform_Platforms_PlatformsGuid",
                table: "GamePlatform",
                column: "PlatformsGuid",
                principalTable: "Platforms",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Publishers_PublisherGuid",
                table: "Games",
                column: "PublisherGuid",
                principalTable: "Publishers",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GameUser_Games_GamesGuid",
                table: "GameUser",
                column: "GamesGuid",
                principalTable: "Games",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Games_GameGuid",
                table: "Payments",
                column: "GameGuid",
                principalTable: "Games",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Ratings_Games_GameGuid",
                table: "Ratings",
                column: "GameGuid",
                principalTable: "Games",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleGuid",
                table: "Users",
                column: "RoleGuid",
                principalTable: "Roles",
                principalColumn: "Guid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
