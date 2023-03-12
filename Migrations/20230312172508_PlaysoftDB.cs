using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PlaySoftBeta.Migrations
{
    /// <inheritdoc />
    public partial class PlaysoftDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "songID", "publicationDate", "songName" },
                values: new object[,]
                {
                    { 1, new DateTime(2015, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "pumbaPumba" },
                    { 2, new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Temardo bien de guapo" },
                    { 3, new DateTime(1015, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AngryBirdsSongTheme" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "songID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "songID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Songs",
                keyColumn: "songID",
                keyValue: 3);
        }
    }
}
