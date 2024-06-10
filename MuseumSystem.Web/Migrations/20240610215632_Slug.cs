using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MuseumSystem.Web.Migrations
{
    /// <inheritdoc />
    public partial class Slug : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SlugMuseum",
                table: "Museums",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SlugEvent",
                table: "Events",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SlugMuseum",
                table: "Museums");

            migrationBuilder.DropColumn(
                name: "SlugEvent",
                table: "Events");
        }
    }
}
