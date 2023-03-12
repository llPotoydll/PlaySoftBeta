using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PlaySoftBeta.Migrations
{
    /// <inheritdoc />
    public partial class db : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Playlist",
                columns: new[] { "playlistID", "playListDuration", "playListName", "playlistDescription", "privacity", "userUKID" },
                values: new object[] { 1, 0.0, "lista", null, true, 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Playlist",
                keyColumn: "playlistID",
                keyValue: 1);
        }
    }
}
