using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlaySoftBeta.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userID);
                });

            migrationBuilder.CreateTable(
                name: "Playlists",
                columns: table => new
                {
                    playlistID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    playListName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    privacity = table.Column<bool>(type: "bit", nullable: false),
                    userID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Playlists", x => x.playlistID);
                    table.ForeignKey(
                        name: "FK_Playlists_Users_userID",
                        column: x => x.userID,
                        principalTable: "Users",
                        principalColumn: "userID");
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    songID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    songName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    duration = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    playlistID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.songID);
                    table.ForeignKey(
                        name: "FK_Songs_Playlists_playlistID",
                        column: x => x.playlistID,
                        principalTable: "Playlists",
                        principalColumn: "playlistID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Playlists_userID",
                table: "Playlists",
                column: "userID");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_playlistID",
                table: "Songs",
                column: "playlistID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Playlists");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
