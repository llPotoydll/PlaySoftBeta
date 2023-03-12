using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlaySoftBeta.Migrations
{
    /// <inheritdoc />
    public partial class DB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    songID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    songName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duration = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    publicationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.songID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UKID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UKID);
                });

            migrationBuilder.CreateTable(
                name: "Playlist",
                columns: table => new
                {
                    playlistID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    playListName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    playlistDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    privacity = table.Column<bool>(type: "bit", nullable: false),
                    playListDuration = table.Column<double>(type: "float", nullable: false),
                    UKID = table.Column<int>(type: "int", nullable: false),
                    UserUKID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlist", x => x.playlistID);
                    table.ForeignKey(
                        name: "FK_Playlist_Users_UserUKID",
                        column: x => x.UserUKID,
                        principalTable: "Users",
                        principalColumn: "UKID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlaylistLines",
                columns: table => new
                {
                    playlistID = table.Column<int>(type: "int", nullable: false),
                    songID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlaylistLines", x => new { x.playlistID, x.songID });
                    table.ForeignKey(
                        name: "FK_PlaylistLines_Playlist_playlistID",
                        column: x => x.playlistID,
                        principalTable: "Playlist",
                        principalColumn: "playlistID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlaylistLines_Songs_songID",
                        column: x => x.songID,
                        principalTable: "Songs",
                        principalColumn: "songID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Playlist_UserUKID",
                table: "Playlist",
                column: "UserUKID");

            migrationBuilder.CreateIndex(
                name: "IX_PlaylistLines_songID",
                table: "PlaylistLines",
                column: "songID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlaylistLines");

            migrationBuilder.DropTable(
                name: "Playlist");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
