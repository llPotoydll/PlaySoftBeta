using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlaySoftBeta.Migrations
{
    /// <inheritdoc />
    public partial class prueba : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Playlists_Users_userID",
                table: "Playlists");

            migrationBuilder.DropForeignKey(
                name: "FK_Songs_Playlists_playlistID",
                table: "Songs");

            migrationBuilder.DropIndex(
                name: "IX_Songs_playlistID",
                table: "Songs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Playlists",
                table: "Playlists");

            migrationBuilder.DropIndex(
                name: "IX_Playlists_userID",
                table: "Playlists");

            migrationBuilder.DropColumn(
                name: "playlistID",
                table: "Songs");

            migrationBuilder.RenameTable(
                name: "Playlists",
                newName: "Playlist");

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "Playlist",
                newName: "UserID");

            migrationBuilder.AlterColumn<int>(
                name: "UserID",
                table: "Playlist",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Playlist",
                table: "Playlist",
                column: "playlistID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Playlist",
                table: "Playlist");

            migrationBuilder.RenameTable(
                name: "Playlist",
                newName: "Playlists");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Playlists",
                newName: "userID");

            migrationBuilder.AddColumn<int>(
                name: "playlistID",
                table: "Songs",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "userID",
                table: "Playlists",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Playlists",
                table: "Playlists",
                column: "playlistID");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_playlistID",
                table: "Songs",
                column: "playlistID");

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_userID",
                table: "Playlists",
                column: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_Playlists_Users_userID",
                table: "Playlists",
                column: "userID",
                principalTable: "Users",
                principalColumn: "userID");

            migrationBuilder.AddForeignKey(
                name: "FK_Songs_Playlists_playlistID",
                table: "Songs",
                column: "playlistID",
                principalTable: "Playlists",
                principalColumn: "playlistID");
        }
    }
}
